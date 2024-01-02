import React, { Component } from "react"
import { View, SafeAreaView, FlatList } from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';

import TextString from './TextString';
import ProductCard from './ProductCard';
import ProductCategoryCard from './ProductCategoryCard';

class ProductList extends Component {
  
    constructor(props) {
      super(props);
      this.prodCategory = props.prodCategory === undefined ? null : props.prodCategory;
      this.prodSubcategory = props.prodSubcategory === undefined ? null : props.prodSubcategory;
      this.prodSearchTerm = props.prodSearchTerm === undefined ? null : props.prodSearchTerm;
      this.prodSortField = props.prodSortField === undefined || props.prodSortField == null ? 'Name' : props.prodSortField;
      this.isFavoritesSortedOnTop = props.prodIsFavoritesSortedOnTop === undefined || props.prodIsFavoritesSortedOnTop == null ? true : props.prodIsFavoritesSortedOnTop;
      this.productCards = [];
      this.productCardList = React.createRef();
      this.state = { productsFound: this.lookForProducts() };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function') {
        props.onCreated(this);
      }
    }

    lookForProducts = () => {
      var ret = [];
      for (const p of ProductCard.getAllCards()) { 
        if (this.prodCategory != null) {
          if (p.Category.startsWith(this.prodCategory)) {
            if (this.prodSubcategory != null) {
              if (p.Price > 0 && p.Category.startsWith(this.prodCategory + ': ' + this.prodSubcategory)) {
                ret.push(p);
              }
            }
            else if (this.prodSearchTerm != null) {
              const isNum = !Number.isNaN(this.prodSearchTerm);
              const isMeeting = p.Price > 0 && ( 
                    isNum && (p.ProductId == this.prodSearchTerm || p.PCPNum == this.prodSearchTerm)
                || p.Category.indexOf(this.prodSearchTerm) >= 0
                || p.Name.indexOf(this.prodSearchTerm) >= 0
                || p.Vendor.indexOf(this.prodSearchTerm) >= 0
              )
              if (isMeeting) {
                ret.push(p);
              }
            }
            else {
              ret.push(p);
            }
          }
        }
        else {
          const isNum = !Number.isNaN(this.prodSearchTerm);
          const isMeeting = 
                isNum && (p.ProductId == this.prodSearchTerm || p.PCPNum == this.prodSearchTerm)
            || p.Category.indexOf(this.prodSearchTerm) >= 0
            || p.Name.indexOf(this.prodSearchTerm) >= 0
            || p.Vendor.indexOf(this.prodSearchTerm) >= 0
          if (isMeeting) {
            ret.push(p);
          }
        }
      }
      var ret = ret.sort( (a, b) => 
        this.prodSortField == 'Category' ?
        (a.Category > b.Category ? 1 : b.Category > a.Category ? -1 : 0) :
        this.prodSortField == 'ProductId' ?
        (a.ProductId > b.ProductId ? 1 : b.ProductId > a.ProductId ? -1 : 0) :
        this.prodSortField == 'Vendor' ?
        (a.Vendor > b.Vendor ? 1 : b.Vendor > a.Vendor ? -1 : 0) :
        (a.Name > b.Name ? 1 : b.Name > a.Name ? -1 : 0)
      );
      if (ret.length == 0) {
        var sarchNotFoundAny = TextString.Get('SearchNotFoundAny')
        setTimeout(() => { alert(sarchNotFoundAny); }, 200);
      }
      if (!this.isFavoritesSortedOnTop) 
        return ret
      var retEx = [];
      for (const p of ret) { if (p.isFavorite) retEx.push(p); };
      for (const p of ret) { if (!p.isFavorite) retEx.push(p); };
      return retEx
    }

  setProdSearchTerm(newCategroy, newProdSubcategory, newProdSearchTerm) {
    this.prodCategory = newCategroy === undefined ? null : newCategroy;
    this.prodSubcategory = newProdSubcategory === undefined ? null : newProdSubcategory;
    this.prodSearchTerm = newProdSearchTerm === undefined ? null : newProdSearchTerm;
    this.setState({ productsFound: this.lookForProducts() });
    this.productCardList.current.scrollToIndex({ index: 0, animated: true} );
    for (const card of this.productCards) { card.forceUpdate(); }
  }
  setProdSortField(sortFavoritesOnTop, newProdSortField) {
    this.isFavoritesSortedOnTop = sortFavoritesOnTop === undefined ? true : sortFavoritesOnTop;
    this.prodSortField = newProdSortField === undefined ? null : newProdSortField;
    this.setState({ productsFound: this.lookForProducts() });
    //this.productCardList.current.forceUpdate();
    this.productCardList.current.scrollToIndex({ index: 0, animated: true} );
    for (const card of this.productCards) { card.forceUpdate(); }
  }

  toggleIsNationalSite() {
    for (const card of this.productCards) { 
      try {
        card.toggleIsNationalSite(); 
      }
      catch (ex) {
        
      }
    }
  } 
  
  renderProductCard = ({ item }) => {
    var itm = this.prodSortField === 'Category' ? item.Category + '\r\n':
              this.prodSortField === 'ProductId' ? item.ProductId + '\r\n' :
              this.prodSortField === 'Vendor' ? item.Vendor + '\r\n' : ''
    itm = itm + item.Name + ':\r\n' + item.Price;
    //alert(itm); 
    return (
      <ProductCard product={item} onCreated={(newCard) => { this.productCards.push(newCard)} }/>
    )
  }

  render() {
    return (
        <SafeAreaView style={this.props.style}>
          <FlatList
            ref={this.productCardList}
            style={{margin:0, marginTop: 2, padding:8, width: '100%',}}
            contentContainerStyle={{ paddingBottom: 12}}
            data={this.state.productsFound}
            renderItem={this.renderProductCard} 
            keyExtractor={item => item.ProductId}
            ItemSeparatorComponent={() => <View style={{height: 4}} />}
          />
      </SafeAreaView>
    );
  }
}
    
export default ProductList;
