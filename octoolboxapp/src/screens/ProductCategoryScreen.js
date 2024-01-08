import * as React from 'react';
import { useCallback, useRef, useEffect } from "react";
import { View, Text, SafeAreaView, FlatList, StyleSheet, TextInput } from 'react-native';
import { Button } from '@rneui/base';
import Icon from 'react-native-vector-icons/FontAwesome';
import { CommonActions } from "@react-navigation/native";
import AsyncStorage from '@react-native-async-storage/async-storage';

import SearchBox from '../components/SearchBox';
import IconButton from '../components/IconButton';
import ProductCategories from '../jsons/ProductCategories.json';
import ProductCategoriesFr from '../jsons/ProductCategoriesFr.json';
import ProductCard from '../components/ProductCard';
import ProductCategoryCard from '../components/ProductCategoryCard';

import TextString from '../components/TextString';

const ProductCategoryScreen = ({navigation}) => {
    const screenTitle = TextString.Get('ProdCat').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
    }, 200);

    var searchBox = null;

    if (global.isNationalSite === undefined) {
      global.isNationalSite = false;
    }
    const siteTypeButtonRef = useRef();
    const siteTypeButtonIcon = { 
      name: (!global.isNationalSite ? 'account-question' : 'check-square-o'), 
      type: (!global.isNationalSite ? 'material-community' : "font-awesome"), 
      size: 18, 
      color: '#ffffff', 
    };
    const siteTypeButtonTitle = !global.isNationalSite ? 'National?' : 'National!'
    const siteTypeButtonToggle = useCallback(() => {
      this.siteTypeButtonIcon = { 
        name: (!global.isNationalSite ? 'account-question' : 'check-square-o'), 
        type: (!global.isNationalSite ? 'material-community' : "font-awesome"), 
        size: 18, 
        color: '#ffffff', 
      };
      this.siteTypeButtonTitle = !global.isNationalSite ? 'National?' : 'National!'
      siteTypeButtonRef.current.changeState(this.siteTypeButtonIcon, this.siteTypeButtonTitle);
    }, []);

    const renderCategory = ({ item }) => (
      <ProductCategoryCard 
        category={item} 
        onCategorySelected={(categoryId) => {
          global.prodCategory = categoryId;
          global.prodSubcategory = null;
          global.prodSearchTerm = null;
          global.prodSortField = "Name";
          global.prodIsFavoritesSortedOnTop = true;
          navigation.navigate('Product')
        }}
        onSubcategorySelected={(categoryId, subcategoryId) => {
          global.prodCategory = categoryId;
          global.prodSubcategory = subcategoryId;
          global.prodSearchTerm = null;
          global.prodSortField = "Name";
          global.prodIsFavoritesSortedOnTop = true;
          navigation.navigate('Product')
        }}
      />
    );  

    return (
        <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <View style={{height: 48, width: '100%', backgroundColor: '#333333',}}>
            <SearchBox 
              style={{widith: '100%', backgroundColor: '#ffffff', borderRadius: 5, marginTop: 4, marginLeft: 8, marginRight: 8,}} 
              placeholder={TextString.Get('SearchProd')}
              onCreated = {(searchBoxInstance) => { searchBox = searchBoxInstance; }}
              onSearchButtonClicked = {(searchTerm) => {
                global.prodCategory = null;
                global.prodSubcategory = null;
                global.prodSearchTerm = searchTerm.toUpperCase();
                global.prodSortField = "Name";
                global.prodIsFavoritesSortedOnTop = true;
                navigation.navigate('Product')
              }}
            />
          </View>
          <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333',}}>
              <FlatList 
                style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
                contentContainerStyle={{ paddingBottom: 12}}
                data={ProductCategoryCard.getAllCards()} 
                renderItem={renderCategory} 
                keyExtractor={item => item.id}
                ItemSeparatorComponent={() => <View style={{height: 4}} />}
              />
          </SafeAreaView>
          <View style={{height: 4, width: '100%', backgroundColor: "#333333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
          <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
          <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
          <View style={[styles.buttonListContainer, {flex: 0, height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}]}>
              <View style={[{width: global.isInPreviewMode ? "40%" : "100%"}]}>
                <Button 
                  title={TextString.Get('Home').toUpperCase()}
                  titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                  icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
                  iconContainerStyle={{ marginRight: 6 }}
                  buttonStyle={{ backgroundColor: '#333333', }}
                  onPress={() => { navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]})); }}
                />
              </View>
              {
              /*
              global.isInPreviewMode &&
              <View style={[{width: "60%"}]}>
                <Button 
                  title={('Get Updates').toUpperCase()}
                  titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                  icon={{ name: 'download', type: 'font-awesome', size: 16, color: '#ffffff', }}
                  iconContainerStyle={{ marginRight: 6 }}
                  buttonStyle={{ backgroundColor: '#333333', }}
                  onPress={() => { 
                    navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "PriceDataDownload", goTo : "ProductCategory", goBack: "ProductCategory" }]})); 
                  }}
                />
              </View>
              */
              }
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
  
export default ProductCategoryScreen