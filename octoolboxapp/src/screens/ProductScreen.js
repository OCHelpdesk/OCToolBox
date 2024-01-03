import * as React from 'react';
import { useRef } from "react";
import { View, StyleSheet } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";

import SearchBox from '../components/SearchBox';
//import IconButton from '../components/IconButton';
import ProductList from '../components/ProductList';
import ProductListSetNational from '../components/ProductListSetNational';
import ProductListSetSort from '../components/ProductListSetSort';
import TextString from '../components/TextString';

const ProductScreen = ({navigation, route}) => {
  var screenTitle = (global.prodCategory == null ? TextString.Get('Product') : global.prodCategory).toUpperCase();
  setTimeout(() => {
    //Directly run navigation.setOptions({ title: screenTitle }) would cause a conflict because
    //setOptions changes state of NativeStackNavigator while NativeStackNavigator is updating
    //its state at this point. So delay to run navigation.setOptions({ title: screenTitle }).
    navigation.setOptions({ title: screenTitle })
  }, 500);
  const searchInputInitValue = global.prodSearchTerm != null ? global.prodSearchTerm : global.prodSubcategory != null ? global.prodCategory + ': ' + global.prodSubcategory : null;

  /*
  const siteTypeButtonRef = useRef();
  var siteTypeButtonIcon = { 
    name: (!global.isNationalSite ? 'account-question' : 'check-square-o'), 
    type: (!global.isNationalSite ? 'material-community' : "font-awesome"), 
    size: 18, 
    color: '#ffffff', 
  };
  var siteTypeButtonTitle = TextString.Get('National').toUpperCase() + (!global.isNationalSite ? '?' : '!');
  const siteTypeButtonToggle = useCallback(() => {
    siteTypeButtonIcon = { 
      name: (!global.isNationalSite ? 'account-question' : 'check-square-o'), 
      type: (!global.isNationalSite ? 'material-community' : "font-awesome"), 
      size: 18, 
      color: '#ffffff', 
    };
    siteTypeButtonTitle = TextString.Get('National').toUpperCase() + (!global.isNationalSite ? '?' : '!');
    siteTypeButtonRef.current.changeState(siteTypeButtonIcon, siteTypeButtonTitle);
  }, []);
  */

  var productList = useRef();
  return (
    <View>
    <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
      <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
      <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
      <View style={{height: 48, width: '100%', backgroundColor: '#333333',}}>
      <SearchBox 
              style={{widith: '100%', backgroundColor: '#ffffff', borderRadius: 5, marginTop: 4, marginLeft: 8, marginRight: 8,}}
              placeholder={(global.prodCategory == null ? TextString.Get('SearchProd') : TextString.Get('SearchProdInCat').replace('{xxx}', global.prodCategory))}
              defaultValue={searchInputInitValue}
              onCreated = {(searchBoxInstance) => {  }}
              onSearchButtonClicked = {(searchTerm) => {
                global.prodSubcategory = null;
                global.prodSearchTerm = searchTerm.toUpperCase();
                productList.current.setProdSearchTerm(global.prodCategory, global.prodSubcategory, global.prodSearchTerm);
              }}
            />
      </View>
      <ProductList
        ref={productList}
        style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#333333'}}
        prodCategory={global.prodCategory}
        prodSubcategory={global.prodSubcategory}
        prodSearchTerm={global.prodSearchTerm}
        prodSortField={global.prodSortField}
        prodIsFavoritesSortedOnTop={global.prodIsFavoritesSortedOnTop}
      />
      <View style={{height: 4, width: '100%', backgroundColor: "#333333"}} />
      <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
      <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
      <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      <View style={[styles.buttonListContainer, {flex: 0, height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}]}>
        <View style={[{width: "30%"}]}>
          <Button 
            title={TextString.Get('Home').toUpperCase()}
            titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff', }}
            icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
            iconContainerStyle={{ marginRight: 6 }}
            buttonStyle={{ backgroundColor: '#333333', }}
            onPress={() => {
              navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]}));
            }}
          />
        </View>
        <View style={[{width: "30%"}]}>
          <ProductListSetSort 
            sortField='Name'
            titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff', }}
            icon={{ name: 'sort', type: 'font-awesome', size: 16, color: '#ffffff', }}
            iconContainerStyle={{ marginRight: 6 }}
            buttonStyle={{ backgroundColor: '#333333', }}
            onSorFieldChanged={(sortFavoritesOnTop, newSortField) => {
              global.prodSortField = newSortField;
              global.prodIsFavoritesSortedOnTop = sortFavoritesOnTop;
              productList.current.setProdSortField(sortFavoritesOnTop, newSortField);
            }}
          />
        </View>
        <View style={[{width: "40%"}]}>
          <ProductListSetNational
            style={{marginTop: 8}}
            iconSize={16} iconColor="#ffffff"
            fontStyle={{color: "#ffffff", fontWeight: 'bold', fontSize: 16, marginLeft: 6}}
            onPressIn = {() => { productList.current.toggleIsNationalSite(); }}
            onPressOut = {() => { productList.current.toggleIsNationalSite(); }}
          />
        </View>
      </View>
      <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
    </View>
    </View>
  )
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
  
export default ProductScreen