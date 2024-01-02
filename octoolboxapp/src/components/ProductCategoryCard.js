import React, { Component } from "react"
import { Modal, SafeAreaView, FlatList, Text, Image, TouchableOpacity, View, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import { Button } from '@rneui/base';
import { AssetImages } from "./AssetImages";
import TextString from '../components/TextString';

import ProductCategories from '../jsons/ProductCategories.json';
import ProductCategoriesFr from '../jsons/ProductCategoriesFr.json';

class ProductCategoryCard extends Component {
    static AllEnCards = null;
    static AllFrCards = null;
    static loadAllCards() {
      ProductCategoryCard.AllEnCards = ProductCategories;
      ProductCategoryCard.AllFrCards = ProductCategoriesFr;
    }
    static getAllCards() {
      return TextString.IsInFrench() ? ProductCategoryCard.AllFrCards : ProductCategoryCard.AllEnCards;
    }

    constructor(props) {
      super(props);
      this.state = { isSubcategoryBoxShowing: false };
      this.imgUri = AssetImages.GetUri(props.category.image);
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onCategorySelected = () => {
      if (this.props.onCategorySelected !== undefined && this.props.onCategorySelected != null && typeof this.props.onCategorySelected === 'function')
        this.props.onCategorySelected(this.props.category.id);  
    };
    onSubcategorySelected = (subcategory) => {
      if (this.props.onSubcategorySelected !== undefined && this.props.onSubcategorySelected != null && typeof this.props.onSubcategorySelected === 'function')
        this.props.onSubcategorySelected(this.props.category.id, subcategory);  
    };
  
    render() {
        const renderSubcategory = ({ item }) => {
          return (
            <Button 
              title={item}
              titleStyle={{ color: '#ffffff', fontWeight: "bold", fontSize: 14 }}
              type="outline" 
              buttonStyle={{
                borderWidth: 1,
                borderColor: "#ffffff",
                borderRadius: 5,
                justifyContent: "flex-start" ,
              }}
              onPress={() => {
                this.setState({isSubcategoryBoxShowing: false})
                this.onSubcategorySelected(item);
              }}
            />
          )
        }
        const screenHeight = parseInt(Dimensions.get('window').height);
        const modalBoxHeight = 600;
        const modalBoxMarginTop = (screenHeight - modalBoxHeight) / 2;
        return (
        <View>
          <Modal visible={this.state.isSubcategoryBoxShowing} transparent={true}>
            <View style={{backgroundColor: "#000000cc", flex: 1}}>
              <View 
                style={{
                  height: modalBoxHeight, 
                  marginRight: 50, marginLeft: 50, marginTop: modalBoxMarginTop,
                  padding: 8,
                  backgroundColor: "#333333",
                  borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                }}>
                <TouchableOpacity
                  style={{flexDirection: "row", borderBottomWidth: 1, borderBottomColor: "#333333"}}
                  onPress={() => {this.setState({isSubcategoryBoxShowing: false})}}
                >
                  <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 12, fontWeight: "bold", color: "#ffffff", paddingTop: 4}}>{TextString.Get('ProdSubcatSelect').toUpperCase()}</Text>
                  <Icon name="close" size={22} color="#ffffff" style={{flex: 0, width: 22, }} />
                </TouchableOpacity>
                <View style={{height: 2, borderBottomWidth: 1, borderBottomColor: "#ff0000", paddingBottom: 8, alignItems: 'center'}}></View>
                {
                this.props.category.subcategories.length == 0
                &&
                <Text style={{fontSize: 12, fontWeight: "bold", color: "#ffffff", textAlign: "center", paddingTop: 20}}>(NO SUBCATEGORIES)</Text>
                }
                <SafeAreaView style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch',}}>
                    <FlatList 
                      style={{margin:0, padding:8, width: '100%',}}
                      contentContainerStyle={{ paddingBottom: 12}}
                      data={this.props.category.subcategories} 
                      renderItem={renderSubcategory} 
                      ItemSeparatorComponent={() => <View style={{height: 8}} />}
                    />
                </SafeAreaView>
              </View>
            </View>
          </Modal>
          <TouchableOpacity
            style={{
              height: 160, 
              width: '100%', 
              flexDirection: "row",
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              margin: 0, padding: 4,
              backgroundColor: "#ffffff"
            }}
            onPress={this.onCategorySelected}
          >
            <View style={{
              width: 150, height: 150,
              marginLeft: 4, marginTop: 2, padding: 0,
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              }}>
              <Image source={this.imgUri} style={{ width: '100%', height: '100%', }} />            
            </View>
            <View style={{
              flex: 2, 
              flexDirection: "column",
              alignSelf: 'stretch',
              marginLeft: 4, marginTop: 2, padding: 2,
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              }}>
              <View style={{flex: 1, alignSelf: 'stretch'}}>
                <Text style={{fontWeight: "bold", fontSize: 12, color: "#666666"}}>{TextString.Get('ProdCat').toUpperCase()}:</Text>
                <Text style={{fontWeight: "bold", color: "#ff0000"}}>{this.props.category.name.toUpperCase()}</Text>
                <Text style={{fontWeight: "bold", fontSize: 12, color: "#666666", paddingTop: 6}}>{TextString.Get('ProdCatDesc').toUpperCase()}:</Text>
                <Text style={{fontSize: 14}}>{this.props.category.description}</Text>
              </View>
              <TouchableOpacity style={{height: 32, flexDirection: "row"}} onPress={() => {this.setState({isSubcategoryBoxShowing: true})}}>
                <Text style={{flex: 1, alignSelf: 'stretch', marginTop: 4, color: "#0000ff", fontWeight: "bold", textDecorationLine: "underline"}}>{TextString.Get('ProdSubcat').toUpperCase()}</Text> 
              </TouchableOpacity>
            </View>
          </TouchableOpacity>
        </View>
      );
    }
  }
  
  
  export default ProductCategoryCard;
