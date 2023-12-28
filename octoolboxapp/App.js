import * as React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import AsyncStorage from '@react-native-async-storage/async-storage';
import BackgroundService from 'react-native-background-actions';

import AppSettings from './src/jsons/AppSettings.json'
import AppHomeScreen from './src/screens/AppHomeScreen';
import DocListScreen from './src/screens/DocListScreen';

const Stack = createNativeStackNavigator();

function App() {
  global.currentProductDataVersion = '';
  global.isInPreviewMode = false
  const getIsInPreviewMode = async() => {
    try {
      var v = await AsyncStorage.getItem('@UserSettings_IsInPreviewMode')
      global.isInPreviewMode = v !== null ? (v == 'true') : false;
    } catch(e) {
      global.isInPreviewMode = false;
    }    
  }
  getIsInPreviewMode();
  
  return (
    <NavigationContainer>
      <Stack.Navigator >
        <Stack.Screen name="AppHome" component={AppHomeScreen} options={{
          headerBackVisible: false,
          title: 'OCTOOLBOX',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }}/>
        <Stack.Screen name="DocList" component={DocListScreen} options={{
          //headerShown: false,
          headerBackVisible: false,
          title: 'Doc. List',
          headerTitleAlign: 'center',          
          headerTintColor: '#ffffff',
          headerStyle: {backgroundColor: '#ff0000', borderBottomWidth: 0, },
          headerShadowVisible: false,
        }} />
      </Stack.Navigator>
    </NavigationContainer>
  );
}

export default App;
