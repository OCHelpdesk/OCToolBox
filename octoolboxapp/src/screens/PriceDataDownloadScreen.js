import * as React from 'react';
import { View, Image, StyleSheet } from 'react-native';
import { CommonActions } from "@react-navigation/native";
import AsyncStorage from '@react-native-async-storage/async-storage';

import ProductCard from '../components/ProductCard';
import ProductCategoryCard from '../components/ProductCategoryCard';
import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

const PriceDataDownloadScreen = ({navigation, route}) => {
    const navStackScreenNameGoTo = route == null || route.goTo == null ? "ProductCategory" : route.params.goTo;
    const navStackScreenNameGoBack = route == null || route.goBack == null ? "AppHome" : route.params.goBack;
    const plsTryAgain = "Product price data didn't get downloaded. Please make sure you have a mobile or WiFi connection to Internet.";
    const screenTitle = TextString.Get('PlsWait').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
      setTimeout(() => {
        var apiURL = AppSettings.UrlPriceData;
        var request = {
          method: 'POST',
          headers: { Accept: 'application/json', 'Content-Type': 'application/json; charset=utf-8', },
          body: JSON.stringify({
            AccessKey: AppSettings.AppServiceAccessKey,
            AppSideVersionNumber: "0.0", //Force to download the full package, no matter what price data version the app is having.
            RequestVersionNumberOnly: false,
            RequestPreviewVersion: global.isInPreviewMode,
          }),
        }
        fetch(apiURL, request)
        .then((response) => response.json())
        .then(async (responseJson) => {
          var isGoodResponse = responseJson != null && responseJson.Version !== undefined && responseJson.Version !== null;
          if (isGoodResponse) {
            isGoodResponse = isGoodResponse &&
              responseJson.ProductCategories !== undefined && responseJson.ProductCategories !== null &&
              responseJson.ProductCategoriesFr !== undefined && responseJson.ProductCategoriesFr !== null &&
              responseJson.Products !== undefined && responseJson.Products !== null &&
              responseJson.ProductsFr !== undefined && responseJson.ProductsFr !== null;
            if (isGoodResponse) {
              console.log("Full package of the product price data has been downloaded! Version #: " + responseJson.Version);
              ProductCategoryCard.AllEnCards = responseJson.ProductCategories;
              ProductCategoryCard.AllFrCards = responseJson.ProductCategoriesFr;
              ProductCard.AllEnCards = responseJson.Products;
              ProductCard.AllFrCards = responseJson.ProductsFr;
              for (const p of ProductCard.AllEnCards)  { p.isFavorite = false; }
              for (const p of ProductCard.AllFrCards)  { p.isFavorite = false; }
              var favorites = [];
              try {
                const jsonString = await AsyncStorage.getItem(AppSettings.FavoriteProductsSettingName);
                if (jsonString != null) 
                  favorites = JSON.parse(jsonString);
              } catch(e) {
                console.error('Error loading favorite products: ' + e);
              }           
              for (const p of ProductCard.AllEnCards)  { p.isFavorite = favorites.includes(p.ProductId); }
              for (const p of ProductCard.AllFrCards)  { p.isFavorite = favorites.includes(p.ProductId); }
              await AsyncStorage.setItem(AppSettings.PriceDataVersionSettingName, responseJson.Version);
              navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: navStackScreenNameGoTo }]}));
            }
            else {
              alert(plsTryAgain);
              navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: navStackScreenNameGoBack }]}));
            }
          }
          else {
            alert(plsTryAgain);
            navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: navStackScreenNameGoBack }]}));
          }
          return responseJson;
        })
        .catch((error) => {
          console.error("Error while Download Data: " + error);
          alert(plsTryAgain);
          navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: navStackScreenNameGoBack }]}));
        });
      }, 1000);
    }, 200);
    return (
        <View style={{flex: 1, flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <View style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
            <Image source={require('../../assets/oc/LadyBug.gif')} style={{ width: 100, height: 100, }} />
          </View>
          <View style={{height: 4, width: '100%', backgroundColor: "#333333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
          <View style={[styles.buttonListContainer, {flex: 0, height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}]}>
          </View>
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>
    );
  };


const styles = StyleSheet.create({
  buttonListContainer: {
    flex: 1,
    flexDirection: 'row',
    alignItems: 'flex-start',
    justifyContent: 'center',
  },
  buttonContainer: {
    flex: 1,
  },
});
  
export default PriceDataDownloadScreen