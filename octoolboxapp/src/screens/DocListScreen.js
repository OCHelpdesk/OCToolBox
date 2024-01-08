import React, { Component } from "react"
import { View, SafeAreaView, FlatList, Text, Modal, Dimensions, TouchableOpacity, Image } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
import RNFS from 'react-native-fs';
import FileViewer from 'react-native-file-viewer'

import DocCard from '../components/DocCardEx';
import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

class DocListScreen extends Component {
  constructor(props) {
    super(props);
    //By console.log(props), you can see props has properties of navigation, route, etc. 
    //Note property name of route doesn't have s while the parameter name is routes, having s, 
    //when DocWaitList submitted the navigation request. 
    //console.log(props)
    this.navigation = props.navigation;
    this.docs = props.route.docs != null ? props.route.docs : props.route.params.docs;
    this.state = { isPleaseWaitOpen: false };
    const screenTitle = TextString.Get('Doc').toUpperCase();
    setTimeout(() => {
      this.navigation.setOptions({ title: screenTitle });
    }, 200);
  }

  filesInDir = async (dirPath) => {
    console.log('Calling RNFS.readDir on ' + dirPath);
    const arrayOfReadDirItem = await RNFS.readDir(dirPath);
    console.log('Iterate through the return array');
    for (var i = 0; i < arrayOfReadDirItem.length; i++) {
      //For definition of type ReadDirItem, Refer https://www.npmjs.com/package/react-native-fs
      console.log(arrayOfReadDirItem[i].name);
    }
  };


  viewDoc = async (docId, docCard) => {
    //console.log('View Doc with Id: ' + docId);
    var fileName = '';
    for (var d = 0; d < this.docs.length; d++) {
      if (this.docs[d].Id == docId) {
        fileName = RNFS.DocumentDirectoryPath + '/' + this.docs[d].FileName;
        break;
      }
    }
    if (fileName == '') {
      console.log('No doc is with : ' + docId);        
      return;
    }
    var isExisting = await RNFS.exists(fileName)
    if (isExisting) {
      await RNFS.unlink(fileName); //Remove the file
      //console.log('File ' + fileName + ' Deleted');        
    }
    var url = AppSettings.UrlDocData.replace('@DocId', docId).replace('@InFrench', TextString.IsInFrench() ? '1' : '0');
    //console.log(url);
    await RNFS.downloadFile({fromUrl: url, toFile: fileName}).promise
    .then((res) => {
      //Success
      //filesInDir(RNFS.DocumentDirectoryPath); 
      //this.setState({isPleaseWaitOpen: false})
      docCard.hidePleaseWait();
      setTimeout(() => {
        FileViewer.open(fileName)
        .then(() => {
          //console.log('Opened ' + fileName)
        })
        .catch((err) => {
          console.log(err); 
        });
      }, 100);
    })
    .catch((res) => {
      console.log("Didn't get the file downloaded!");
    });
  }
  
  renderDoc = ({ item }) => (
    <DocCard 
      doc={item} 
      onDocSelected={(docId, docCard) => {
        //this.setState({isPleaseWaitOpen: true})
        docCard.showPleaseWait();
        setTimeout(() => { this.viewDoc(docId, docCard); }, 100);
      }}
    />
  );

  render() {
    //console.log('DocListScreen Rendering Screen')
    //console.log(this.docs);
    const screenHeight = parseInt(Dimensions.get('window').height);
    const modalBoxHeight = 260;
    const modalBoxMarginTop = (screenHeight - modalBoxHeight) / 2;
    return (
        <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
            <Modal visible={this.state.isPleaseWaitOpen} transparent={true}>
                <View style={{backgroundColor: "#00000000", flex: 1}}>
                    <View 
                        style={{
                            height: modalBoxHeight, 
                            marginRight: 60, marginLeft: 60, marginTop: modalBoxMarginTop,
                            padding: 8,
                            backgroundColor: "#00000000",
                            borderWidth: 1, borderColor: "#00000000", borderRadius: 10,
                    }}>
                        <View style={{flex: 1, alignItems: 'center', justifyContent: 'space-evenly', alignSelf: 'stretch',}}>
                          <Image source={require('../../assets/oc/LadyBug.gif')} style={{ width: 100, height: 100, }} />
                        </View>
                    </View>
                </View>
            </Modal>
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
            <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
              <FlatList 
                style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
                contentContainerStyle={{ paddingBottom: 12}}
                data={this.docs} 
                renderItem={this.renderDoc} 
                keyExtractor={(item, index) => { return item.Id; }}
                ItemSeparatorComponent={() => <View style={{height: 4}} />}
              />
            </SafeAreaView>
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
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>
    )
  }
}
  
export default DocListScreen