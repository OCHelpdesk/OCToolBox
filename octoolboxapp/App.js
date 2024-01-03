import * as React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import AsyncStorage from '@react-native-async-storage/async-storage';
import BackgroundService from 'react-native-background-actions';

import AppSettings from './src/jsons/AppSettings.json'
import ProductCard from './src/components/ProductCard';
import ProductCategoryCard from './src/components/ProductCategoryCard';

import AppHomeScreen from './src/screens/AppHomeScreen';
import DocWaitListScreen from './src/screens/DocWaitListScreen';
import DocListScreen from './src/screens/DocListScreen';
import PriceDataDownloadScreen from './src/screens/PriceDataDownloadScreen';
import ProductCategoryScreen from './src/screens/ProductCategoryScreen';
import ProductScreen from './src/screens/ProductScreen';
import RateCardCommercialServiceScreen from './src/screens/RateCardCommercialServiceScreen';
import RateCardResidentialServiceScreen from './src/screens/RateCardResidentialServiceScreen';

const Stack = createNativeStackNavigator();

// You can do anything in your task such as network requests, timers and so on,
// as long as it doesn't touch UI. Once your task completes (i.e. the promise is resolved),
// React Native will go into "paused" mode (unless there are other tasks running,
// or there is a foreground app).
const backgroundTask = async (taskDataArguments) => {
  const { delay } = taskDataArguments;
  const runBackgroundTask = async() => {
    try {
      var timeLastCheckPriceUpdateStr = await AsyncStorage.getItem(AppSettings.BgTaskTimeLastCheckPriceUpdateSettingName);
      var timeNow = new Date();
      if (timeLastCheckPriceUpdateStr == null) {
        var startedAt = timeNow.toString();
        await AsyncStorage.setItem(AppSettings.BgTaskTimeLastCheckPriceUpdateSettingName, startedAt);
        console.log('GbTask Started at ' + startedAt + '.');
        if (timeNow.getHours() >= 2) {
          timeNow.setHours(timeNow.getHours() - 2);
        }
        timeLastCheckPriceUpdateStr = timeNow.toString();
      }
      {
        timeNow = new Date();
        var timeLastCheckPriceUpdate = Date.parse(timeLastCheckPriceUpdateStr);
        if ((Math.abs(timeNow.getTime() - timeLastCheckPriceUpdate) / (60 * 60 * 1000)) >= 1) {
          console.log('GbTask Triggered at ' + timeNow.toString() + '.');
          var isInPreviewMode = await AsyncStorage.getItem(AppSettings.IsInPreviewModeSettingName)
          isInPreviewMode = isInPreviewMode == null ? 'false' : isInPreviewModeStr;
          var priceDataVersion = await AsyncStorage.getItem(AppSettings.PriceDataVersionSettingName)
          priceDataVersion = priceDataVersion == null ? AppSettings.PriceDataVersion : priceDataVersion;
          var apiURL = AppSettings.UrlPriceData;
          var request = {
            method: 'POST',
            headers: { Accept: 'application/json', 'Content-Type': 'application/json; charset=utf-8', },
            body: JSON.stringify({
              AccessKey: AppSettings.AppServiceAccessKey,
              AppSideVersionNumber: priceDataVersion,
              RequestVersionNumberOnly: false,
              RequestPreviewVersion: isInPreviewMode == 'true',
            }),
          }
          fetch(apiURL, request)
          .then((response) => response.json())
          .then(async (responseJson) => {
            var isGoodResponse = responseJson != null && responseJson.Version !== undefined && responseJson.Version !== null;
            if (isGoodResponse && responseJson.Version === priceDataVersion) {
              await AsyncStorage.setItem(AppSettings.BgTaskTimeLastCheckPriceUpdateSettingName, timeNow.toString());
              console.log("GbTask: No Updates.");
            }
            else if (isGoodResponse) {
              console.log("GbTask: Has Updates.");
              isGoodResponse = isGoodResponse &&
                responseJson.ProductCategories !== undefined && responseJson.ProductCategories !== null &&
                responseJson.ProductCategoriesFr !== undefined && responseJson.ProductCategoriesFr !== null &&
                responseJson.Products !== undefined && responseJson.Products !== null &&
                responseJson.ProductsFr !== undefined && responseJson.ProductsFr !== null;
              if (isGoodResponse) {
                console.log("GbTask: Updates Fetched.");
                ProductCategoryCard.AllEnCards = responseJson.ProductCategories;
                ProductCategoryCard.AllFrCards = responseJson.ProductCategoriesFr;
                ProductCard.AllEnCards = responseJson.Products;
                ProductCard.AllFrCards = responseJson.ProductsFr;
                for (const p of ProductCard.AllEnCards)  { p.isFavorite = false; }
                for (const p of ProductCard.AllFrCards)  { p.isFavorite = false; }
                var favorites = [];
                const jsonString = await AsyncStorage.getItem(AppSettings.FavoriteProductsSettingName);
                if (jsonString != null) favorites = JSON.parse(jsonString);
                for (const p of ProductCard.AllEnCards)  { p.isFavorite = favorites.includes(p.ProductId); }
                for (const p of ProductCard.AllFrCards)  { p.isFavorite = favorites.includes(p.ProductId); }
                await AsyncStorage.setItem(AppSettings.PriceDataVersionSettingName, responseJson.Version);
                await AsyncStorage.setItem(AppSettings.BgTaskTimeLastCheckPriceUpdateSettingName, timeNow.toString());
                console.log("GbTask: Updates Applied. Version #: " + responseJson.Version);
              }
              else {
                console.error("GbTask: Updates Not Acceptable.");
              }
            }
            else {
              console.error("GbTask: Updates Missing Version #.");
            }
            return responseJson;
          })
          .catch((error) => {
            console.error("GbTask Error while Fetching Product Data Updates: " + error);
          });
        }  
      }
    } catch (e) {
      console.error(e.toString())
    }
  }
  const backgroundTaskSleep = (time) => new Promise((resolve) => setTimeout(() => resolve(), time));
  // An infinite loop task
  await new Promise( async (resolve) => {
      for (let i = 0; BackgroundService.isRunning(); i++) {
          runBackgroundTask();
          //await backgroundTaskSleep(delay);
          await backgroundTaskSleep(60 * 1000); //wait a minute
      }
  });
};
const backgroundTaskOptions = {
  taskName: 'OCToolboxBgTask',
  taskTitle: 'OC Toolbox Background Task',
  taskDesc: 'Background Task to do Price Update and Others',
  taskIcon: { name: 'ic_launcher', type: 'mipmap',}, //Android Required. Notification icon.
  color: '#ff00ff', //Notification color. Default: "#ffffff".
  linkingURI: 'yourSchemeHere://chat/jane', // For more info, see Deep Linking on https://www.npmjs.com/package/react-native-background-actions
  parameters: { delay: 1000, },
};


function App() {
  const startBackgroundService = async() => {
    await AsyncStorage.removeItem(AppSettings.PriceDataVersionSettingName);
    await AsyncStorage.removeItem(AppSettings.BgTaskTimeLastCheckPriceUpdateSettingName);
    await BackgroundService.start(backgroundTask, backgroundTaskOptions);
    await BackgroundService.updateNotification({taskDesc: 'OC Toolbox Background Task Started'}); // Only Android, iOS will ignore this call  
    //iOS will also run everything here in the background until .stop() is called
  }
  /*
  If you call stop() on background no new tasks will be able to be started! 
  Don't call .start() twice, as it will stop performing previous background tasks 
  and start a new one. 
  If .start() is called on the backgound, it will not have any effect.  
  */
  const stopBackgroundService = async() => {
    await BackgroundService.stop();
  }
  startBackgroundService();

  return (
    <NavigationContainer>
      <Stack.Navigator >
        <Stack.Screen name="AppHome" component={AppHomeScreen} options={{
          headerBackVisible: false,
          title: 'ORKIN CANADA',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }}/>
        <Stack.Screen name="DocWaitList" component={DocWaitListScreen} options={{
          //headerShown: false,
          headerBackVisible: false,
          title: 'Please Wait...',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }} />
        <Stack.Screen name="DocList" component={DocListScreen} options={{
          //headerShown: false,
          headerBackVisible: false,
          title: 'Document',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }} />
        <Stack.Screen name="PriceDataDownload" component={PriceDataDownloadScreen} options={{
          //headerShown: false,
          headerBackVisible: false,
          title: 'PLEAE WAIT......',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }}/>
        <Stack.Screen name="ProductCategory" component={ProductCategoryScreen} options={{
          //headerShown: false,
          headerBackVisible: false,
          title: 'PRODUCT CATEGORY',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }} />
        <Stack.Screen name="Product" component={ProductScreen} options={{ 
          //headerShown: false, 
          headerBackVisible: true,
          title: 'PRODUCT',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0},
          headerShadowVisible: false,
        }}  />
        <Stack.Screen name="CommercialService" component={RateCardCommercialServiceScreen} options={{ 
          //headerShown: false, 
          headerBackVisible: true,
          title: 'COMMERCIAL SERVICE',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0},
          headerShadowVisible: false,
        }}  />
        <Stack.Screen name="ResidentialService" component={RateCardResidentialServiceScreen} options={{ 
          //headerShown: false, 
          headerBackVisible: true,
          title: 'RESIDENTIAL SERVICE',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0},
          headerShadowVisible: false,
        }}  />
      </Stack.Navigator>
    </NavigationContainer>
  );
}

export default App;
