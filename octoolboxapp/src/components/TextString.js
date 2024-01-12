import * as React from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';
import TextStrings from '../jsons/TextStrings.json';

class TextString {
    static getIsInFrench = async () => {
        var ret = false;
        try {
            var v = await AsyncStorage.getItem('@UserSettings_IsInFrench')
            ret = v !== null ? (v == 'true') : false;
        } catch(e) {
            ret = false
            console.log('Error while getting @UserSettings_IsInFrench');
        }
        //console.log('getIsInFrench ' + ret);
        global.isFr = ret;
      }
    static setIsInFrench = async (value) => {
        try {
            await AsyncStorage.setItem('@UserSettings_IsInFrench', value ? 'true' : 'false')
        } catch (e) {
            console.log('Error while setting @UserSettings_IsInFrench');
        }
      }

    static IsInFrench = () => {
        if (global.isFr === undefined) {
            global.isFr = false;
        }
        return global.isFr;
    }
    static TargetLanguage = () => {
        if (global.isFr === undefined) {
            global.isFr = false;
        }
        return global.isFr ? 'English' : 'Français'
    }
    static ToggleLanguage = () => {
        if (global.isFr === undefined) {
            global.isFr = false;
        }
        global.isFr = !global.isFr
        TextString.setIsInFrench(global.isFr);
    }
    static Get = (stringId, locale) => {
        for (const s of TextStrings) { 
            if (s.StringId == stringId) {
                return locale === undefined ? (global.isFr ? s.StringFr : s.StringEn) : (locale.toUpperCase() == 'FR' ? s.StringFr : s.StringEn);
            }
        }
        console.log('(text string for Id ' + stringId + ' not found)')
        return stringId;    
    };
}

export default TextString;