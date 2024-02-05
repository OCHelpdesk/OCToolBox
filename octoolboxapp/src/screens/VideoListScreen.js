import React, { Component } from "react"
import { View, SafeAreaView, FlatList, Text, TextInput, Modal, Dimensions, TouchableOpacity, Image } from 'react-native';
import RNFS from 'react-native-fs';

import AppSettings from '../jsons/AppSettings.json'

class VideoListScreen extends Component {
  showFiles = async () => {
    var folder = RNFS.DocumentDirectoryPath + AppSettings.TempFileSubfolder;
    folder = RNFS.MainBundlePath;
    const arrayOfReadDirItem = await RNFS.readDir(folder);
    console.log('Iterate through files in folder: ' + folder);
    for (var i = 0; i < arrayOfReadDirItem.length; i++) {
      console.log(arrayOfReadDirItem[i].name);
    }
  }

  constructor(props) {
    super(props);
    this.showFiles();
  }

  render() {
    const file = 'file://' + RNFS.DocumentDirectoryPath + AppSettings.TempFileSubfolder + '/2024 Comercial Service Rate Card .png';
    console.log(file); 
    var imgSource = require('../../assets/oc/OCLogoEx.png');
    //imgSource = require(file);
    return (
      <View style={{ height: '100%', width: '100%'}}>
        <Image source={{uri: file}} style={{ width: "100%", height: "100%", resizeMode: 'stretch',}} />
      </View>
    )
  }
}

export default VideoListScreen