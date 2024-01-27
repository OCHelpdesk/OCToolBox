import * as React from 'react';
import { useState } from "react";
import { View, Image, Text, TouchableWithoutFeedback, Alert, Modal, Dimensions, TouchableOpacity  } from 'react-native';
import { CommonActions } from "@react-navigation/native";
import AsyncStorage from '@react-native-async-storage/async-storage';
import Icon from 'react-native-vector-icons/FontAwesome';
import { Button } from '@rneui/base';

import ProductCard from '../components/ProductCard';
import ProductCategoryCard from '../components/ProductCategoryCard';
import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

const AppHomeScreen = ({navigation}) => {
    const [priceDataVersion, setPriceDataVersion] = useState(AppSettings.PriceDataVersion);
    const getPriceDataVersion = async() => {
      try {
        var v = await AsyncStorage.getItem(AppSettings.PriceDataVersionSettingName);
        setPriceDataVersion( v !== null ? v : AppSettings.PriceDataVersion );
      } catch(e) {
        console.error(e);
      }    
    }
    //Keep checking price data version as the background price data download task can find and 
    //download a new version.
    setInterval(() => {
        getPriceDataVersion().then(() => {
            //console.log('AppHomeScreen.getPriceDataVersion Executed!');
        });
    }, 2000);

    global.isInPreviewMode = false
    const getIsInPreviewMode = async() => {
      try {
        var v = await AsyncStorage.getItem(AppSettings.IsInPreviewModeSettingName);
        global.isInPreviewMode = v !== null ? (v == 'true') : false;
        //console.log('AppHomeScreen.getIsInPreviewMode Executed!');
      } catch(e) {
        global.isInPreviewMode = false;
      }    
    }
    getIsInPreviewMode();  
    
    const [stringLanguage, setLanguage] = useState('Français');
    const [stringOCToolbox, setStringOCToolbox] = useState('OC Pro Toolbox'.toUpperCase());
    const [stringSelectCat, setStringSelectCat] = useState('select a toolbox category');
    const [stringPricing, setStringPricing] = useState('Pricing');
    const [stringSelectPricingCat, setStringSelectPricingCat] = useState('select a price category');
    const [stringProdPrice, setStringProdPrice] = useState('Product / Produit'.toUpperCase());
    const [stringServicePriceComm, setStringServicePriceComm] = useState('Service - Commercial'.toLocaleUpperCase());
    const [stringServicePriceResi, setStringServicePriceResi] = useState('Service - Residential'.toLocaleUpperCase());
    const [stringDoc, setStringDoc] = useState('Document'.toUpperCase());
    const [isPricingMenuOpen, setIsPricingMenuOpen] = useState(false);
    const [isPleaseWaitOpen, setIsPleaseWaitOpen] = useState(false);

    TextString.getIsInFrench().then(
        () => {
            var screenTitle = 'ORKIN CANADA ' + TextString.Get('OCToolbox').toUpperCase();
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringSelectPricingCat(TextString.Get('HomeSelectCat'));
            setStringProdPrice(TextString.Get('HomeProdPrice').toUpperCase());
            setStringServicePriceComm(TextString.Get('HomeSvcPriceComm').toUpperCase());
            setStringServicePriceResi(TextString.Get('HomeSvcPriceResi').toUpperCase());
            setStringDoc(TextString.Get('Doc').toUpperCase());
        }
    ) 
    const toggleLanguage = () => {
        TextString.ToggleLanguage();
            var screenTitle = 'ORKIN CANADA ' + TextString.Get('OCToolbox').toUpperCase();
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringSelectPricingCat(TextString.Get('HomeSelectCat'));
            setStringProdPrice(TextString.Get('HomeProdPrice').toUpperCase());
            setStringServicePriceComm(TextString.Get('HomeSvcPriceComm').toUpperCase());
            setStringServicePriceResi(TextString.Get('HomeSvcPriceResi').toUpperCase());
            setStringDoc(TextString.Get('Doc').toUpperCase());
    }

    var timeLogoLastPressed = new Date().getTime();
    const setIsInPreviewMode = async(value) => {
        try {
            await AsyncStorage.setItem(AppSettings.IsInPreviewModeSettingName, value ? 'true' : 'false');
            global.isInPreviewMode = value;
        } catch (e) {
            console.log('Unable to ' + (value ? 'set' : 'reset') + ' preview mode.');
        }
      }
    const toggleIsInPreviewMode = () => {
        var title = global.isInPreviewMode ? 'Exit Preview Mode?' : 'Start Preview Mode?';
        var msg = global.isInPreviewMode ? "" : "Preview mode enables features and/or data about to release.\n\nPreview mode is retained until you exit it."
        Alert.alert(title, msg, [
            {text: 'YES', onPress: () => { setIsInPreviewMode(!global.isInPreviewMode); AsyncStorage.removeItem(AppSettings.PriceDataVersionSettingName); }, style: 'yes'},
            {text: 'NO', style: 'no',},
        ]);    
      }

    loadPriceData = async () => {
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
              setIsPleaseWaitOpen(false);
              setTimeout( () => { clearInterval(); navigation.navigate('ProductCategory'); }, 100);
            }
            else {
              setIsPleaseWaitOpen(false);
              //alert(plsTryAgain);
            }
          }
          else {
            setIsPleaseWaitOpen(false);
            //alert(plsTryAgain);
          }
          return responseJson;
        })
        .catch((error) => {
          setIsPleaseWaitOpen(false);
          console.error("Error while Download Data: " + error);
          //alert(plsTryAgain);
        });
    }

    loadDocList = async () => {
        //console.log('Loading Doc List');
        var apiURL = AppSettings.UrlDocList;
        var request = {
          method: 'POST',
          headers: { Accept: 'application/json', 'Content-Type': 'application/json; charset=utf-8', },
          body: JSON.stringify({
            AccessKey: AppSettings.AppServiceAccessKey,
            InFrench: TextString.IsInFrench(),
            InPreview: global.isInPreviewMode,
          }),
        }
        fetch(apiURL, request)
        .then((response) => response.json())
        .then(async (responseJson) => {
          if (responseJson != null && responseJson.Docs != null) {
              //setIsPleaseWaitOpen(false);
              setTimeout( () => { clearInterval(); navigation.navigate('DocList', {docs: responseJson.Docs }); }, 100);
          }
          else {
              //setIsPleaseWaitOpen(false);
              console.error("Didn't get document list downloaded.");
          }
          return responseJson;
        })
        .catch((error) => {
            //setIsPleaseWaitOpen(false);
            console.error("Error while Loading Doc List: " + error);
        });
      }
    
    const screenHeight = parseInt(Dimensions.get('window').height);
    const modalBoxHeight = 320;
    const modalBoxMarginTop = (screenHeight - modalBoxHeight) / 2;
    return (
        <View style={{width: '100%', height: '100%', flexDirection: "column", alignItems: 'center', backgroundColor: "#333333"}}>
            <Modal visible={isPricingMenuOpen} transparent={true}>
                <View style={{backgroundColor: "#00000066", flex: 1}}>
                    <View 
                        style={{
                            height: modalBoxHeight, 
                            marginRight: 40, marginLeft: 40, marginTop: modalBoxMarginTop,
                            padding: 8,
                            backgroundColor: "#333333",
                            borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                    }}>
                        <TouchableOpacity
                            style={{flexDirection: "row", borderBottomWidth: 1, borderBottomColor: "#333333"}}
                            onPress={() => { setIsPricingMenuOpen(false); }}
                        >
                            <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 12, fontWeight: "bold", color: "#ffffff", paddingTop: 4, paddingLeft: 4}}>{stringSelectPricingCat}</Text>
                            <Icon name="close" size={22} color="#ffffff" style={{flex: 0, width: 22, }} />
                        </TouchableOpacity>
                        <View style={{height: 2, borderBottomWidth: 1, borderBottomColor: "#ff0000", paddingBottom: 8, alignItems: 'center'}}></View>
                        <View style={{flex: 3, alignItems: 'center', justifyContent: 'space-evenly', alignSelf: 'stretch',}}>
                            <Button 
                                title={stringProdPrice}
                                titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 16 }}
                                type="outline" 
                                buttonStyle={{ width: 240, height: 40, borderWidth: 1, borderColor: "#ffffff", borderRadius: 5 }}
                                onPress={() => { 
                                    setIsPricingMenuOpen(false);
                                    setIsPleaseWaitOpen(true);
                                    setTimeout(() => { loadPriceData(); }, 1000);
                                }}
                            />
                            <Button 
                                title={stringServicePriceComm}
                                titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 16 }}
                                type="outline" 
                                buttonStyle={{ width: 240, height: 40, borderWidth: 1, borderColor: "#ffffff", borderRadius: 5 }}
                                onPress={() => { 
                                    setIsPricingMenuOpen(false);
                                    clearInterval();
                                    setTimeout(() => { navigation.navigate('CommercialService'); }, 200);
                                }}
                            />
                            <Button 
                                title={stringServicePriceResi}
                                titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 16 }}
                                type="outline" 
                                buttonStyle={{ width: 240, height: 40, borderWidth: 1, borderColor: "#ffffff", borderRadius: 5 }}
                                onPress={() => { 
                                    setIsPricingMenuOpen(false);
                                    clearInterval();
                                    setTimeout(() => { navigation.navigate('ResidentialService'); }, 200);
                                }}
                            />
                        </View>
                    </View>
                </View>
            </Modal>
            <Modal visible={isPleaseWaitOpen} transparent={true}>
                <View style={{backgroundColor: "#00000066", flex: 1}}>
                    <View 
                        style={{
                            height: modalBoxHeight, 
                            marginRight: 40, marginLeft: 40, marginTop: modalBoxMarginTop,
                            padding: 8,
                            backgroundColor: "#00000000",
                            borderWidth: 0, borderColor: "#ff0000", borderRadius: 5,
                            alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', 
                    }}>
                        <Image source={require('../../assets/oc/LadyBug.gif')} style={{ width: 100, height: 100, }} />
                    </View>
                </View>
            </Modal>
            <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
            <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
            <View
                style={{
                flex: 1, alignItems: 'center', justifyContent: "center", alignSelf: 'stretch',
                width: '90%', margin: 20,
                borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                }}>
                <TouchableWithoutFeedback
                    onPressIn = { () => { timeLogoLastPressed = new Date().getTime(); }}
                    onPressOut = { () => { if (((new Date().getTime()) - timeLogoLastPressed) > 3000) toggleIsInPreviewMode(); }}
                >
                    <View style={{width: '95%', height: 50, borderBottomWidth: 1, borderBottomColor: "#ff0000", justifyContent: "center", alignItems: 'center'}}>
                        <Text style={{fontWeight: "bold", color: "#ffffff", fontSize: 20, paddingTop: 10, paddingBottom: 10}}>{stringOCToolbox}</Text>
                    </View>
                </TouchableWithoutFeedback>
                <View style={{paddingTop: 20, paddingBottom: 0, alignItems: 'center'}}>
                    <Text style={{ fontWeight: "bold", color: "#ffffff", fontSize: 14}}>{stringSelectCat}</Text>
                </View>
                <View style={{flex: 3, alignItems: 'center', justifyContent: 'space-evenly', alignSelf: 'stretch',}}>
                    <Button 
                        title={stringPricing}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 20 }}
                        type="outline" 
                        buttonStyle={{ width: 300, height: 68, borderWidth: 1, borderColor: "#ffffff", borderRadius: 20 }}
                        onPress={() => { setIsPricingMenuOpen(true); }}
                    />
                    <Button 
                        title={stringDoc}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 20 }}
                        type="outline" 
                        buttonStyle={{ width: 300, height: 68, borderWidth: 1, borderColor: "#ffffff", borderRadius: 20 }}
                        onPress={() => { 
                            //setIsPleaseWaitOpen(true);
                            //setTimeout(() => { loadDocList(); }, 1000);
                            loadDocList();
                        }}
                    />
                </View>
                <View style={{paddingTop: 120, paddingBottom: 40, alignItems: 'center'}}>
                    <Button 
                        title={stringLanguage}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 20 }}
                        type="outline" 
                        buttonStyle={{ width: 260, height: 48, borderWidth: 1, borderColor: "#ffffff", borderRadius: 24 }}
                        onPress={() => { 
                            toggleLanguage();
                        }}
                    />
                </View>
            </View>
            <Text style={{height: 20, color: "#ffffff", fontSize: 16, fontWeight: "bold", textAlign: 'center'}}>
                V { AppSettings.AppVersion }, { priceDataVersion }
            </Text>
            <View style={{height: 60, flexDirection: "row", alignItems: 'center', justifyContent: 'center', }}>
                <Image source={require('../../assets/oc/OCLogoEx.png')} style={{ width: 46, height: 24, resizeMode: 'stretch',}} />
                <Text style={{color: "#ffffff", fontSize: 16, fontWeight: "bold", paddingLeft: 10 }}>
                    ORKIN CANADA
                </Text>
            </View>
        </View>
    )
}

export default AppHomeScreen