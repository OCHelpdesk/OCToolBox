import React, { Component } from "react"
import { View, SafeAreaView, FlatList, Text, TextInput, Modal, Dimensions, TouchableOpacity, Image } from 'react-native';
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
    this.categories = props.route.categories != null ? props.route.categories : props.route.params.categories;
    this.docs = props.route.docs != null ? props.route.docs : props.route.params.docs;
    this.state = { isPleaseWaitOpen: false, categories: this.categories, docs: this.docs };
    this.docCardList = React.createRef();
    this.searchTextInput = React.createRef();
    this.searchText = '';
    this.searchCategoryId = '';
    const screenTitle = TextString.Get('Doc').toUpperCase();
    setTimeout(() => {
      this.navigation.setOptions({ title: screenTitle });
    }, 200);
  }

  viewDoc = async (docId, docCard) => {
    //console.log('View Doc with Id: ' + docId);
    var fileName = '';
    for (var d = 0; d < this.docs.length; d++) {
      if (this.docs[d].Id == docId) {
        fileName = RNFS.DocumentDirectoryPath + AppSettings.TempFileSubfolder + '/' + this.docs[d].FileName;
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

  refreshDocList = async() => {
    this.setState({isPleaseWaitOpen: true});
    setTimeout(() => {
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
            this.setState({isPleaseWaitOpen: false});
            setTimeout( () => { 
              this.categories = responseJson.Categories;
              this.docs = responseJson.Docs;
              this.setState({categories: this.categories, docs: this.docs});
              setTimeout(() => {
                this.docCardList.current.scrollToIndex({ index: 0, animated: true} );
              }, 100) 
            }, 100);
        }
        else {
            this.setState({isPleaseWaitOpen: false});
            console.error("Didn't get document list downloaded.");
        }
        return responseJson;
      })
      .catch((error) => {
          this.setState({isPleaseWaitOpen: false});
          console.error("Error while Loading Doc List: " + error);
      });
    }, 1000);
  }
  
  renderDoc = ({ item }) => (
    <DocCard 
      doc={item} 
      onDocSelected={(docId, docCard) => {
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
    const cardWidth = parseInt(Dimensions.get('window').width) - 24;
    return (
        <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
            <Modal visible={this.state.isPleaseWaitOpen} transparent={true}>
                <View style={{backgroundColor: "#00000066", flex: 1}}>
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
          <View style={{
              position: "relative",
              height: 40, width: cardWidth, 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 12, marginTop: 2, padding: 4,
              backgroundColor: "#ffffff"
          }}>
            <TextInput
              ref={this.searchTextInput}
              style={{
                height: 30, width: cardWidth - 100, 
                position: "absolute", top: 4, left: 4,
                borderWidth: 1, borderColor: "#cccccc", borderRadius: 5, 
                marginLeft: 4, marginTop: 2, padding: 4,
              }}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'search', type: 'font-awesome', size: 16, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 4, left: 220, }}
                onPress={() => {  }}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'remove', type: 'font-awesome', size: 20, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 2, left: 320, }}
                onPress={() => {  
                  this.searchText = '';
                  this.searchCategoryId = '';
                  this.searchTextInput.current.clear();
                }}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'list', type: 'font-awesome', size: 16, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 5, left: 280, }}
                onPress={() => {  

                }}
            />
          </View>
            <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
              <FlatList
                ref={this.docCardList} 
                style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
                contentContainerStyle={{ paddingBottom: 12}}
                data={this.state.docs} 
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
              <View style={[{width: "50%"}]}>
                <Button 
                  title={TextString.Get('Home').toUpperCase()}
                  titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                  icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
                  iconContainerStyle={{ marginRight: 6 }}
                  buttonStyle={{ backgroundColor: '#333333', }}
                  onPress={() => { this.navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]})); }}
                />
              </View>
              <View style={[{width: "50%"}]}>
                <Button 
                  title={TextString.Get('Refresh').toUpperCase()}
                  titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                  icon={{ name: 'refresh', type: 'font-awesome', size: 16, color: '#ffffff', }}
                  iconContainerStyle={{ marginRight: 6 }}
                  buttonStyle={{ backgroundColor: '#333333', }}
                  onPress={() => { this.refreshDocList(); }}
                />
              </View>
          </View>
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>
    )
  }
}
  
export default DocListScreen