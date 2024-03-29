import React, { Component } from "react"
import { StyleSheet, View, SafeAreaView, FlatList, Text, TextInput, Modal, Dimensions, TouchableOpacity, Image } from 'react-native';
import Icon from 'react-native-vector-icons/FontAwesome';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
import RNFS from 'react-native-fs';
import FileViewer from 'react-native-file-viewer'

import Card from '../components/LabelSdsCard';
import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

class LabelSdsListScreen extends Component {
  constructor(props) {
    super(props);
    this.navigation = props.navigation;
    this.data = props.route.params.data;
    this.refCardList = React.createRef();
    this.refCategoryList = React.createRef();
    this.categoryType = '';
    this.refSearchText = React.createRef();
    this.searchText = '';
    this.state = { isPleaseWaitOpen: false, isCategoryBoxOpen: false, searchCategoty: '', products: this.data.Products, categories: [] };
    const screenTitle = TextString.Get('SDSLabel&SDS').toUpperCase();
    setTimeout(() => {
      this.navigation.setOptions({ title: screenTitle });
    }, 200);
  }

  filterBySearchText = () => {
    const sText = this.searchText.replace(' ', '').toUpperCase();
    if (sText != '') {
      var ret = [];
      for (var d = 0; d < this.data.Products.length; d++) {
        if (this.data.Products[d].Name.replace(' ', '').toUpperCase().indexOf(sText) >= 0 || 
            this.data.Products[d].Manufacturer.replace(' ', '').toUpperCase().indexOf(sText) >= 0 ||
            this.data.Products[d].PCP.replace(' ', '').toUpperCase().indexOf(sText) >= 0 ||
            this.data.Products[d].RevisionNumber.replace(' ', '').toUpperCase().indexOf(sText) >= 0 ||
            this.data.Products[d].Ingredient.replace(' ', '').toUpperCase().indexOf(sText) >= 0 ||
            this.data.Products[d].TargetPests.replace(' ', '').toUpperCase().indexOf(sText) >= 0
           ) {
          ret.push(this.data.Products[d]);
        }
      }    
      this.setState({ searchCategoty: '', products: ret }); 
      if (ret.length > 0) {
        setTimeout(() => { this.refCardList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
      } 
    }
  }

  filterByCategory = (categoryId, category) => {
    this.refSearchText.current.clear();
    this.searchText = '';
    const ids = categoryId.split(':');
    var ret = [];
    for (var d = 0; d < this.data.Products.length; d++) {
      if (this.categoryType == "Manufacturers" && this.data.Products[d].Manufacturer.toUpperCase() == category.toUpperCase() ||
          this.categoryType == "Locations" && this.data.Products[d].LocationId == categoryId ||
          this.categoryType == "PesticideClasses" && this.data.Products[d].PesticideClassId == categoryId ||
          this.categoryType == "FormulationTypes" && this.data.Products[d].FormulationTypeId == categoryId ||
          this.categoryType == "TargetPests" && (this.data.Products[d].TargetPestIds.indexOf('[' + categoryId + ']') >= 0 || (ids[1] == '0' && this.data.Products[d].TargetPestIds.indexOf('[' + ids[0] + ':') >= 0)) 
         ){
        ret.push(this.data.Products[d]);
      }
    }    
    this.setState({searchCategoty: category, products: ret});
    if (ret.length > 0) {
      setTimeout(() => { this.refCardList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
    } 
  }

  refreshList = async() => {
    this.refSearchText.current.clear();
    this.searchText = '';
    this.setState({searchCategoty: '', isPleaseWaitOpen: true});
    setTimeout(() => {
      var apiURL = AppSettings.UrlLabelSdsList;
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
        if (responseJson != null) {
            this.setState({isPleaseWaitOpen: false});
            setTimeout( () => { 
              this.data = responseJson;
              this.setState({products: this.data.Products});
              if (this.data.Products.length > 0) {
                setTimeout(() => { this.refCardList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
              } 
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

  viewDoc = async (docId, docName, refCard) => {
    refCard.showPleaseWait();
    var fileName = RNFS.DocumentDirectoryPath + AppSettings.TempFileSubfolder + '/' + docName;
    var isExisting = await RNFS.exists(fileName)
    if (isExisting) {
      await RNFS.unlink(fileName); //Remove the file
    }
    var url = AppSettings.UrlLabelSdsDocData.replace('@DocId', docId);
    await RNFS.downloadFile({fromUrl: url, toFile: fileName}).promise
    .then((res) => {
      //Success
      refCard.hidePleaseWait();
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
      refCard.hidePleaseWait();
      console.log("Didn't get the file downloaded!");
    });
  }

  renderCard = ({ item }) => (
    <Card 
      product={item} 
      onDocSelected={(docId, docName, refCard) => {
        setTimeout(() => { this.viewDoc(docId, docName, refCard); }, 100);
      }}
    />
  );

  renderCategory = ({ item }) => (
    <Button 
      title={item.Name}
      titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
      onPress={() => {
        this.setState({isCategoryBoxOpen: false})
        this.filterByCategory(item.Id, item.Name);
      }}
    />
  );

  render() {
    //console.log('DocListScreen Rendering Screen')
    //console.log(this.docs);
    const screenHeight = parseInt(Dimensions.get('window').height);
    const modalBoxHeight = 260;
    const modalBoxMarginTop = (screenHeight - modalBoxHeight) / 2;
    const categoryBoxHeight = 600;
    const categoryBoxMarginTop = (screenHeight - categoryBoxHeight) / 2;
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
            <Modal visible={this.state.isCategoryBoxOpen} transparent={true}>
                <View style={{backgroundColor: "#000000cc", flex: 1}}>
                    <View 
                        style={{
                            height: categoryBoxHeight, 
                            marginRight: 50, marginLeft: 50, marginTop: categoryBoxMarginTop,
                            padding: 8,
                            backgroundColor: "#333333",
                            borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                    }}>
                        <TouchableOpacity
                          style={{flexDirection: "row", borderBottomWidth: 1, borderBottomColor: "#333333"}}
                          onPress={() => {this.setState({isCategoryBoxOpen: false})}}
                        >
                          <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 12, fontWeight: "bold", color: "#ffffff", paddingTop: 4}}>{TextString.Get('SelectCategory').toUpperCase()}</Text>
                          <Icon name="close" size={22} color="#ffffff" style={{flex: 0, width: 22, }} />
                        </TouchableOpacity>
                        <View style={{height: 2, borderBottomWidth: 1, borderBottomColor: "#ff0000", paddingBottom: 8, alignItems: 'center'}}></View>
                        <View style={{ height: 220, justifyContent: 'space-evenly', paddingLeft: 8, paddingRight: 8}}>
                          <Button 
                            title={TextString.Get('Manufactory').toUpperCase()}
                            titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
                            onPress={() => {
                              this.categoryType = 'Manufacturers';
                              this.setState({categories: this.data.Manufacturers})
                              setTimeout(() => { this.refCategoryList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                            }}
                          />
                          <Button 
                            title={TextString.Get('SDSTargetPest').toUpperCase()}
                            titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
                            onPress={() => {
                              this.categoryType = 'TargetPests';
                              this.setState({categories: this.data.TargetPests})
                              setTimeout(() => { this.refCategoryList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                            }}
                          />
                          <Button 
                            title={TextString.Get('SDSLocation').toUpperCase()}
                            titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
                            onPress={() => {
                              this.categoryType = 'Locations';
                              this.setState({categories: this.data.Locations})
                              setTimeout(() => { this.refCategoryList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                            }}
                          />
                          <Button 
                            title={TextString.Get('SDSPesticideClass').toUpperCase()}
                            titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
                            onPress={() => {
                              this.categoryType = 'PesticideClasses';
                              this.setState({categories: this.data.PesticideClasses})
                              setTimeout(() => { this.refCategoryList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                            }}
                          />
                          <Button 
                            title={TextString.Get('SDSFormulationType').toUpperCase()}
                            titleStyle={ styles.buttonListTitle } type="outline" buttonStyle={ styles.buttonListButton }
                            onPress={() => {
                              this.categoryType = 'FormulationTypes';
                              this.setState({categories: this.data.FormulationTypes})
                              setTimeout(() => { this.refCategoryList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                            }}
                          />
                        </View>
                        <View style={{height: 2, borderBottomWidth: 1, borderBottomColor: "#ff0000", paddingBottom: 8, alignItems: 'center'}}></View>
                        <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch'}}>
                            <FlatList
                              ref={this.refCategoryList} 
                              style={{margin:0, paddingLeft:8, paddingRight:8, paddingBottom:8, paddingTop:16, width: '100%',}}
                              contentContainerStyle={{ paddingBottom: 16}}
                              data={this.state.categories} 
                              renderItem={this.renderCategory} 
                              ItemSeparatorComponent={() => <View style={{height: 8}} />}
                            />
                        </SafeAreaView>
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
              ref={this.refSearchText}
              style={{
                height: 30, width: cardWidth - 116, 
                position: "absolute", top: 4, left: 4,
                borderWidth: 1, borderColor: "#cccccc", borderRadius: 5, 
                marginLeft: 4, marginTop: 2, padding: 4,
              }}
              onChangeText={(newText) => { this.searchText = newText; }}
              returnKeyType='search'
              onSubmitEditing={() => { this.filterBySearchText(); }}
              placeholder={ this.state.searchCategoty }
              maxLength={30}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'search', type: 'font-awesome', size: 16, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 4, left: cardWidth - 160, }}
                onPress={() => { this.filterBySearchText(); }}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'list', type: 'font-awesome', size: 16, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 5, left: cardWidth - 96, }}
                onPress={() => { 
                  this.categoryType = '';
                  this.setState({isCategoryBoxOpen: true, categories: [] }); 
                }}
            />
            <Button
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'remove', type: 'font-awesome', size: 20, color: '#666666', }}
                type="clear" 
                buttonStyle={{width: 60, margin: 0 }}
                containerStyle={{position: "absolute", top: 2, left: cardWidth - 46, }}
                onPress={() => {  
                  this.refSearchText.current.clear();
                  this.searchText = '';
                  this.setState({searchCategoty: "", products: this.data.Products});
                  if (this.data.Products.length > 0) {
                    setTimeout(() => { this.refCardList.current.scrollToIndex({ index: 0, animated: true} ); }, 100);
                  } 
                }}
            />
          </View>
          <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
            <FlatList
                ref={this.refCardList} 
                style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
                contentContainerStyle={{ paddingBottom: 12}}
                data={this.state.products} 
                renderItem={this.renderCard} 
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
                  onPress={() => { this.refreshList(); }}
                />
              </View>
          </View>
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>
    )
  }
}
  
const styles = StyleSheet.create({
  buttonListTitle: { color: '#ffffff', fontWeight: "bold", fontSize: 12 },
  buttonListButton: { borderWidth: 1, borderColor: "#ffffff", borderRadius: 5, justifyContent: "flex-start" }
});

export default LabelSdsListScreen