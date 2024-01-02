import React, { Component } from "react"
import { View, Image, Alert, } from 'react-native';
import { CommonActions } from "@react-navigation/native";
import { Button } from '@rneui/base';

import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

class DocWaitListScreen extends Component {
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
      //console.log('Doc List Loaded');
      setTimeout(() => {
        //console.log(responseJson.Docs);
        //this.props.navigation.navigate('DocList', {docs: responseJson.Docs})
        if (responseJson != null && responseJson.Docs != null) {
          this.props.navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "DocList", docs: responseJson.Docs }]}));
        }
        else {
          alert("Didn't get document list downloaded.");
        }
      }, 200);
      return responseJson;
    })
    .catch((error) => {
      console.error("Error while Loading Doc List: " + error);
    });
  }
 
  constructor(props) {
    super(props);
    this.navigation = props.navigation;
    this.route = props.route
    const screenTitle = TextString.Get('PlsWait').toUpperCase();
    setTimeout(() => {
      this.navigation.setOptions({ title: screenTitle });
      this.loadDocList();
    }, 200);
  }

  render() {
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
      <View style={{flexDirection: 'row', alignItems: 'flex-start', justifyContent: 'center', height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}}>
          <View style={[{width: "100%"}]}>
            <Button 
              title={TextString.Get('Home').toUpperCase()}
              titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
              icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
              iconContainerStyle={{ marginRight: 6 }}
              buttonStyle={{ backgroundColor: '#333333', }}
              onPress={() => { this.navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]})); }}
            />
          </View>
      </View>
      <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} /></View>
    )
  }
}

export default DocWaitListScreen