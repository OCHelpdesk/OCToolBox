import * as React from 'react';
import { View, SafeAreaView, FlatList, StyleSheet } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
import RNFS from 'react-native-fs';

import DocCard from '../components/DocCard';
import TextString from '../components/TextString';

const DocListScreen = ({navigation}) => {
    const getFileContent = async (path) => {
      console.log('Calling RNFS.readDir on ' + path);
      const arrayOfReadDirItem = await RNFS.readDir(path);
      console.log('Iterate through the return array');
      for (var i = 0; i < arrayOfReadDirItem.length; i++) {
        //For definition of type ReadDirItem, Refer https://www.npmjs.com/package/react-native-fs
        console.log(arrayOfReadDirItem[i].name);
      }
    };

    const screenTitle = TextString.Get('Doc').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
      //AppFolder=RNFS.MainBundlePath
      //AppDocFolder=RNFS.DocumentDirectoryPath
      //DownloadFolder=RNFS.DownloadDirectoryPath (Android and Windows only)
      getFileContent(RNFS.DocumentDirectoryPath); 
    }, 200);

    const docs = 
    [
      {
        DocId: 1,
        DocCategory: 'CATEGORY 1',
        DocName: 'DOC 1',
        DocDescription: 'Doc 1 Description',
        DocIcon: 'file-pdf-o',
        DocIconColor: '#ff0000'
      },
      {
        DocId: 2,
        DocCategory: 'CATEGORY 2',
        DocName: 'DOC 2',
        DocDescription: 'Doc 2 Description',
        DocIcon: 'file-excel-o',
        DocIconColor: '#009900'
      }
    ]

    const renderDoc = ({ item }) => (
      <DocCard 
        doc={item} 
        onCategorySelected={(docId) => {

        }}
      />
    );  

    return (
        <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
              <FlatList 
                style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
                contentContainerStyle={{ paddingBottom: 12}}
                data={docs} 
                renderItem={renderDoc} 
                keyExtractor={item => item.DocId}
                ItemSeparatorComponent={() => <View style={{height: 4}} />}
              />
          </SafeAreaView>
          <View style={{height: 4, width: '100%', backgroundColor: "#333333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
          <View style={[styles.buttonListContainer, {flex: 0, height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}]}>
              <View style={[{width: "100%"}]}>
                <Button 
                  title={TextString.Get('Home').toUpperCase()}
                  titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                  icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
                  iconContainerStyle={{ marginRight: 6 }}
                  buttonStyle={{ backgroundColor: '#333333', }}
                  onPress={() => { navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]})); }}
                />
              </View>
          </View>
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>
    );
  };


const styles = StyleSheet.create({
  buttonListContainer: {
    flex: 1,
    flexDirection: 'row',
    alignItems: 'flex-start',
    justifyContent: 'center',
  },
  buttonContainer: {
    flex: 1,
  },
});
  
export default DocListScreen