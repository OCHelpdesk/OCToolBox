import React, { Component } from "react"
import { StyleSheet, Text, Image, TouchableOpacity, View, TouchableWithoutFeedback } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import AsyncStorage from '@react-native-async-storage/async-storage';
import TextString from '../components/TextString';
import Products from '../jsons/Products.json';
import ProductsFr from '../jsons/ProductsFr.json';

class ProductCard extends Component {
    static AllEnCards = null;
    static AllFrCards = null;
    static async loadAllCards() {
      ProductCard.AllEnCards = Products;
      ProductCard.AllFrCards = ProductsFr;
      for (const p of ProductCard.AllEnCards)  { p.isFavorite = false; }
      for (const p of ProductCard.AllFrCards)  { p.isFavorite = false; }
      try {
        const jsonString = await AsyncStorage.getItem('@AppSettings_FavoriteProducts');
        const favorites = jsonString != null ? JSON.parse(jsonString) : [];
        for (const p of ProductCard.AllEnCards)  { p.isFavorite = favorites.includes(p.ProductId); }
        for (const p of ProductCard.AllFrCards)  { p.isFavorite = favorites.includes(p.ProductId); }
      } catch(e) {
        console.log('Error loading favorite products: ' + e);
      }
    }
    static getAllCards() {
      return TextString.IsInFrench() ? ProductCard.AllFrCards : ProductCard.AllEnCards;
    }

    constructor(props) {
      super(props);
      this.isNationalSite = global.isNationalSite !== undefined ? global.isNationalSite : false;
      this.state = {
        price: (this.isNationalSite ? props.product.Price * (1 - props.product.PercentOffForNational) : props.product.Price).toFixed(2),
        orkinPrice: props.product.OrkinPrice == null || props.product.OrkinPrice == 0 ? '' : (this.isNationalSite ? props.product.OrkinPrice * (1 - props.product.PercentOffForNational) : props.product.OrkinPrice).toFixed(2),
        priceColor: props.product.PercentOffForNational > 0 && this.isNationalSite ? '#ff0000' : '#333333',
        priceDescription: props.product.PercentOffForNational == 0 ? TextString.Get('ProdNoOff') : this.isNationalSite ? TextString.Get('ProdOffApplied').replace('{xxx}', (100 * props.product.PercentOffForNational).toFixed(2)) : (TextString.IsInFrench() ? "Tenez pour voir\r\nles prix nationaux" : "Hold to See National Pricing"),
        //priceDescription: props.product.PercentOffForNational == 0 ? TextString.Get('ProdNoOff') : this.isNationalSite ? TextString.Get('ProdOffApplied').replace('{xxx}', (100 * props.product.PercentOffForNational).toFixed(2)) : TextString.Get('ProdNationalOff').replace('{xxx}', (100 * props.product.PercentOffForNational).toFixed(2)),
        priceDescriptionColor: props.product.PercentOffForNational > 0 && this.isNationalSite ? '#ff0000' : '#0000ff',
        isFavorite: props.product.isFavorite
      };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    toggleIsNationalSite() {
        this.isNationalSite = !this.isNationalSite;
        this.setState({
          price: (this.isNationalSite ? this.props.product.Price * (1 - this.props.product.PercentOffForNational) : this.props.product.Price).toFixed(2),
          orkinPrice: this.props.product.OrkinPrice == null || this.props.product.OrkinPrice == 0 ? '' : (this.isNationalSite ? this.props.product.OrkinPrice * (1 - this.props.product.PercentOffForNational) : this.props.product.OrkinPrice).toFixed(2),
          priceColor: this.props.product.PercentOffForNational > 0 && this.isNationalSite ? '#ff0000' : '#333333',
          priceDescription: this.props.product.PercentOffForNational == 0 ? TextString.Get('ProdNoOff') : this.isNationalSite ? TextString.Get('ProdOffApplied').replace('{xxx}', (100 * this.props.product.PercentOffForNational).toFixed(2)) : (TextString.IsInFrench() ? "Tenez pour voir\r\nles prix nationaux" : "Hold to See National Pricing"),
          //priceDescription: this.props.product.PercentOffForNational == 0 ? TextString.Get('ProdNoOff') : this.isNationalSite ? TextString.Get('ProdOffApplied').replace('{xxx}', (100 * this.props.product.PercentOffForNational).toFixed(2)) : TextString.Get('ProdNationalOff').replace('{xxx}', (100 * this.props.product.PercentOffForNational).toFixed(2)),
          priceDescriptionColor: this.props.product.PercentOffForNational > 0 && this.isNationalSite ? '#ff0000' : '#0000ff'
        });
    }
    
    toggleIsFarorite() {
        this.props.product.isFavorite = !this.props.product.isFavorite;
        this.setState({ isFavorite: this.props.product.isFavorite });
        var favorites = []
        for (const p of ProductCard.AllEnCards)  { 
          if (p.ProductId == this.props.product.ProductId) p.isFavorite = this.props.product.isFavorite;
          if (p.isFavorite) favorites.push(p.ProductId); 
        }
        for (const p of ProductCard.AllFrCards)  { 
          if (p.ProductId == this.props.product.ProductId) p.isFavorite = this.props.product.isFavorite;
          if (p.isFavorite && !favorites.includes(p.ProductId)) favorites.push(p.ProductId); 
        }
        const jsonString = JSON.stringify(favorites)
        AsyncStorage.setItem('@AppSettings_FavoriteProducts', jsonString)
        .then(() => { /*console.log('Favorite products saved: ' + jsonString);*/ } )
        .catch(error => { console.log('Error saving favorite products: ' + error); } );
    }
  
    render() {
      return (
        <View
          style={{
            width: '100%', 
            flexDirection: "column",
            borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
            margin: 0, padding: 4,
            backgroundColor: "#ffffff"
          }}
        >
          <View style={styles.dataField} >
            <Text style={styles.dataFieldCaption}>{TextString.Get('Category').toUpperCase()}:</Text>
            <Text style={{flex: 1 }}>{this.props.product.Category}</Text>
            {
            this.state.isFavorite
            &&
            <TouchableOpacity style={{flex: 0}} onPress={() => { this.toggleIsFarorite() ;}}>
              <Icon name='heart' size={24} color='#cc0000' style={{width: 40, textAlign: "center", textAlignVertical: "top"}}/>
            </TouchableOpacity>
            }
            {
            !this.state.isFavorite
            &&
            <TouchableOpacity style={{flex: 0}} onPress={() => { this.toggleIsFarorite() ;}}>
              <Icon name='heart' size={24} color='#cccccc' style={{width: 40, textAlign: "center", textAlignVertical: "top"}}/>
            </TouchableOpacity>
            }
          </View>
          <View style={styles.dataField} >
            <Text style={styles.dataFieldCaption}>{TextString.Get('ProdName').toUpperCase()}:</Text>
            <Text style={{flex: 1, fontWeight: "bold", color: "#ff0000"}}>{this.props.product.Name}</Text>
          </View>
          <View style={styles.dataField} >
            <Text style={styles.dataFieldCaption}>{TextString.Get('BOSS #').toUpperCase()}:</Text>
            <Text style={{flex: 1, }}>{this.props.product.ProductId}</Text>
          </View>
          {
          this.props.product.PCPNum != null && this.props.product.PCPNum != ''
          &&
          <View style={styles.dataField} >
            <Text style={styles.dataFieldCaption}>{TextString.Get('ProdPCP#').toUpperCase()}:</Text>
            <Text style={{flex: 1, }}>{this.props.product.PCPNum}</Text>
          </View>
          }
          <View style={styles.dataField} >
            <Text style={styles.dataFieldCaption}>{TextString.Get('Manufactory').toUpperCase()}:</Text>
            <Text style={{flex: 1, }}>{this.props.product.Vendor}</Text>
          </View>
          <View style={[styles.dataField, {marginRight: 16, marginTop: 4, }]} >
            <Text style={[styles.dataFieldCaption]}>{TextString.Get('Price').toUpperCase()}:</Text>
            <View style={{ flex: 2, flexDirection: "row", borderBottomColor: "#cccccc", borderBottomWidth: 1}}>
              <Text style={[styles.dataFieldCaption, {width: 80}]}>{TextString.Get('UOM').toUpperCase()}</Text>
              <Text style={[styles.dataFieldCaption, {textAlign: 'right'}]}>{TextString.Get('UnitPrice').toUpperCase()}</Text>
            </View>
          </View>
          <View style={[styles.dataField, {marginRight: 16}]} >
            <Text style={[styles.dataFieldCaption]}></Text>
            <View style={{ flex: 2, flexDirection: "row"}}>
              <Text style={{width: 100}}>{this.props.product.UOM}</Text>
              <Text style={[styles.dataFieldCaption, {width: 30, textAlign: 'right'}]}>{TextString.IsInFrench() ? '' : '$'}</Text>
              <Text style={[styles.dataField, {flex: 1, textAlign: 'right', paddingEnd: 42, color: (this.state.priceColor)}]}>{TextString.IsInFrench() ? this.state.price.replace('.', ',') + '$' : this.state.price}</Text>
            </View>
          </View>
          {
          this.props.product.OrkinPrice != null && this.props.product.OrkinPrice != 0 && this.props.product.OrkinPrice != this.props.product.Price
          &&
          <View style={[styles.dataField, {marginRight: 16}]} >
            <Text style={[styles.dataFieldCaption]}></Text>
            <View style={{ flex: 2, flexDirection: "row"}}>
              <Text style={{width: 100}}>{this.props.product.OrkinUOM}</Text>
              <Text style={[styles.dataFieldCaption, {width: 30, textAlign: 'right'}]}>{TextString.IsInFrench() ? '' : '$'}</Text>
              <Text style={[styles.dataField, {flex: 1, textAlign: 'right', paddingEnd: 42, color: (this.state.priceColor)}]}>{TextString.IsInFrench() ? this.state.orkinPrice.replace('.', ',') + '$' : this.state.orkinPrice}</Text>
            </View>
          </View>
          }
          {
          this.props.product.PercentOffForNational == 0
          &&  
          <View style={[styles.dataField, {marginRight: 16,}]} >
            <Text style={[styles.dataFieldCaption]}></Text>
            <View style={{ flex: 1, flexDirection: "row", borderTopColor: "#cccccc", borderTopWidth: 1}}>
              <Text style={{fontSize: 12, paddingTop: 4, color: '#333333'}}>{TextString.Get('ProdNoOff').toUpperCase()}</Text>
            </View>
          </View>
          }
          {
          this.props.product.PercentOffForNational != 0
          &&
          <View style={[styles.dataField, {marginRight: 16,}]} >
            <Text style={[styles.dataFieldCaption]}></Text>
            <TouchableWithoutFeedback onPressIn={() => { this.toggleIsNationalSite() }} onPressOut={() => { this.toggleIsNationalSite() }}>
              <View style={{ flex: 1, flexDirection: "row", borderTopColor: "#cccccc", borderTopWidth: 1}}>
                <Text style={{fontSize: 12, paddingTop: 4, color: (this.state.priceDescriptionColor), textDecorationLine: "underline"}}>{this.state.priceDescription.toUpperCase()}</Text>
              </View>
            </TouchableWithoutFeedback>
          </View>
          }
        </View>
      );
    }
  }
  
  const styles = StyleSheet.create({
    dataField: {
      flexDirection: 'row',
    },
    dataFieldCaption: {
      width: 116,
      fontSize: 12, 
      fontWeight: "bold", 
      color: "#666666",
      paddingTop: 2,
    }
  });

  export default ProductCard;
