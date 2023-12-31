import * as React from 'react';
import { View, SafeAreaView, FlatList } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
import RNFS from 'react-native-fs';
import FileViewer from 'react-native-file-viewer'

import DocCard from '../components/DocCard';
import TextString from '../components/TextString';
import AppSettings from '../jsons/AppSettings.json'

const DocListScreen = ({navigation}) => {
    const filesInDir = async (dirPath) => {
      console.log('Calling RNFS.readDir on ' + dirPath);
      const arrayOfReadDirItem = await RNFS.readDir(dirPath);
      console.log('Iterate through the return array');
      for (var i = 0; i < arrayOfReadDirItem.length; i++) {
        //For definition of type ReadDirItem, Refer https://www.npmjs.com/package/react-native-fs
        console.log(arrayOfReadDirItem[i].name);
      }
    };


    const screenTitle = TextString.Get('Doc').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
      //Works for iOS: AppFolder=RNFS.MainBundlePath
      //Works for iOS: AppDocFolder=RNFS.DocumentDirectoryPath
      //Doesn't Work for iOS: DownloadFolder=RNFS.DownloadDirectoryPath (Android and Windows only)
      //filesInDir(RNFS.DocumentDirectoryPath); 
    }, 200);

    const docs = 
    [
      {
        DocId: 2,
        DocCategory: 'BOSS Instructions',
        DocType: 'pdf',
        DocName: 'Mobile Photos for OC',
        DocDescription: 'Instructions on taking phones while performing services with BOSS',
        DocIcon: 'file-pdf-o',
        DocIconColor: '#ff0000'
      },
      {
        DocId: 3,
        DocCategory: 'Customer Instructions',
        DocType: 'pdf',
        DocName: 'BGIS RealMobile Instruction',
        DocDescription: 'Instructions on RealMobile, an app to submit service info to BGIS for services on BGIS sites',
        DocIcon: 'file-excel-o',
        DocIconColor: '#009900'
      }
    ]

    const viewDoc = async (docId) => {
      //console.log('View Doc with Id: ' + docId);
      var fileName = '';
      for (var d = 0; d < docs.length; d++) {
        if (docs[d].DocId == docId) {
          fileName = RNFS.DocumentDirectoryPath + '/' + docs[d].DocName + '.' + docs[d].DocType ;
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
        // filesInDir(RNFS.DocumentDirectoryPath); 
        FileViewer.open(fileName)
        .then(() => {
          //console.log('Opened ' + fileName)
        })
        .catch((err) => {
          console.log(err); 
        });
      })
      .catch((res) => {
        console.log("Didn't get the file downloaded!");
      });
    }

    const renderDoc = ({ item }) => (
      <DocCard 
        doc={item} 
        onDocSelected={(docId) => { viewDoc(docId); }}
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
          <View style={{flexDirection: 'row', alignItems: 'flex-start', justifyContent: 'center', height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}}>
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

  
export default DocListScreen