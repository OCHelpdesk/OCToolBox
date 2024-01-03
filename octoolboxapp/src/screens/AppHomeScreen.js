import * as React from 'react';
import { useState } from "react";
import { View, Image, Text, TouchableWithoutFeedback, Alert, Modal, Dimensions, TouchableOpacity  } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import Icon from 'react-native-vector-icons/FontAwesome';
import { Button } from '@rneui/base';

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
    //Wait 2 seconds for the background price data download task to complete the download
    //and then update the price data version number.
    setTimeout(() => {
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

    TextString.getIsInFrench().then(
        () => {
            var screenTitle = 'OC ' + TextString.Get('OCToolbox').toUpperCase();
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringSelectPricingCat(TextString.Get('HomeSelectCat').toUpperCase());
            setStringProdPrice(TextString.Get('HomeProdPrice').toUpperCase());
            setStringServicePriceComm(TextString.Get('HomeSvcPriceComm').toUpperCase());
            setStringServicePriceResi(TextString.Get('HomeSvcPriceResi').toUpperCase());
            setStringDoc(TextString.Get('Doc').toUpperCase());
        }
    ) 
    const toggleLanguage = () => {
        TextString.ToggleLanguage();
            var screenTitle = 'OC ' + TextString.Get('OCToolbox').toUpperCase();
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringSelectPricingCat(TextString.Get('HomeSelectCat').toUpperCase());
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
        var title = global.isInPreviewMode ? 'Exit Data Preview Mode?' : 'Start Data Preview Mode?';
        var msg = global.isInPreviewMode ? "" : "Preview mode enables features in testing and loads data about to release.\n\nPreview mode is retained until you exit it."
        Alert.alert(title, msg, [
            {text: 'YES', onPress: () => { setIsInPreviewMode(!global.isInPreviewMode); }, style: 'yes'},
            {text: 'NO', style: 'no',},
        ]);    
      }
    const screenHeight = parseInt(Dimensions.get('window').height);
    const modalBoxHeight = 300;
    const modalBoxMarginTop = (screenHeight - modalBoxHeight) / 2;
    return (
        <View style={{width: '100%', height: '100%', flexDirection: "column", alignItems: 'center', backgroundColor: "#333333"}}>
            <Modal visible={isPricingMenuOpen} transparent={true}>
                <View style={{backgroundColor: "#000000cc", flex: 1}}>
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
                                    setTimeout(() => { navigation.navigate('PriceDataDownload'); }, 200);
                                }}
                            />
                            <Button 
                                title={stringServicePriceComm}
                                titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 16 }}
                                type="outline" 
                                buttonStyle={{ width: 240, height: 40, borderWidth: 1, borderColor: "#ffffff", borderRadius: 5 }}
                                onPress={() => { 
                                    setIsPricingMenuOpen(false);
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
                                    setTimeout(() => { navigation.navigate('ResidentialService'); }, 200);
                                }}
                            />
                        </View>
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
                        onPress={() => {
                            setIsPricingMenuOpen(true);
                        }}
                    />
                    <Button 
                        title={stringDoc}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 20 }}
                        type="outline" 
                        buttonStyle={{ width: 300, height: 68, borderWidth: 1, borderColor: "#ffffff", borderRadius: 20 }}
                        onPress={() => { navigation.navigate('DocWaitList'); }}
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