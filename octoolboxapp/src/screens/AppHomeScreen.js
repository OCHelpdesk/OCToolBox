import * as React from 'react';
import { useState } from "react";
import { View, Image, Text, TouchableWithoutFeedback, Alert  } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { Button } from '@rneui/base';

import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

const AppHomeScreen = ({navigation}) => {
    const priceDataVersion = global.currentProductDataVersion == '' ? AppSettings.PriceDataVersion : global.currentProductDataVersion;
    const [stringLanguage, setLanguage] = useState('Français');
    const [stringOCToolbox, setStringOCToolbox] = useState('Orkin Canada Toolbox'.toUpperCase());
    const [stringSelectCat, setStringSelectCat] = useState('select a toolbox category');
    const [stringPricing, setStringPricing] = useState('Pricing');
    const [stringDoc, setStringDoc] = useState('Document'.toUpperCase());
    TextString.getIsInFrench().then(
        () => {
            var screenTitle = TextString.Get('OCToolbox').toUpperCase() + ' - ORKIN CANADA';
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringDoc(TextString.Get('Doc').toUpperCase());
            }
    ) 
    const toggleLanguage = () => {
        TextString.ToggleLanguage();
            var screenTitle = TextString.Get('OCToolbox').toUpperCase() + ' - ORKIN CANADA';
            navigation.setOptions({ title: screenTitle });
            setLanguage(TextString.TargetLanguage());
            setStringOCToolbox(TextString.Get('OCToolbox').toUpperCase());
            setStringSelectCat(TextString.Get('HomeSelectToolboxCat'));
            setStringPricing(TextString.Get('Pricing').toUpperCase());
            setStringDoc(TextString.Get('Doc').toUpperCase());
    }

    var timeLogoLastPressed = new Date().getTime();
    const setIsInPreviewMode = async(value) => {
        try {
            await AsyncStorage.setItem('@UserSettings_IsInPreviewMode', value ? 'true' : 'false');
            global.isInPreviewMode = value;
        } catch (e) {
            console.log('Unable to ' + (value ? 'set' : 'reset') + ' preview mode.');
        }
      }
    const toggleIsInPreviewMode = () => {
        var title = global.isInPreviewMode ? 'Exit Data Preview Mode?' : 'Start Data Preview Mode?';
        var msg = global.isInPreviewMode ? "" : "In preview mode, the app uses the next version of price data which is about to release.\n\nPreview mode is retained until you exit it."
        Alert.alert(title, msg, [
            {text: 'YES', onPress: () => {global.isProductDataLoaded = false; setIsInPreviewMode(!global.isInPreviewMode); }, style: 'yes'},
            {text: 'NO', style: 'no',},
        ]);    
      }
    return (
        <View style={{width: '100%', height: '100%', flexDirection: "column", alignItems: 'center', backgroundColor: "#333333"}}>
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
                            //navigation.navigate('Splash', { waitFor: 'productDownload', routedFrom: "Home" }) 
                        }}
                    />
                    <Button 
                        title={stringDoc}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 20 }}
                        type="outline" 
                        buttonStyle={{ width: 300, height: 68, borderWidth: 1, borderColor: "#ffffff", borderRadius: 20 }}
                        onPress={() => {
                            navigation.navigate('DocList') 
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