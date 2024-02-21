import React, { Component } from "react"
import {StyleSheet, Text, TouchableOpacity, View, Image, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import IconEx from 'react-native-vector-icons/MaterialCommunityIcons';
import { Button } from '@rneui/base';
import TextString from './TextString';


class LabelSdsCard extends Component {

    constructor(props) {
      super(props);
      this.product = this.props.product;
      this.hasLabel = this.product.LabelDocId != '' && this.product.LabelDocId != '0' && this.product.LabelDocName != '';
      this.hasSDS = this.product.SDSDocId != '' && this.product.SDSDocId != '0' && this.product.SDSDocName != '';
      this.state = { isPleaseWaitOpen: false };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onDocSelected = (docId, docName) => {
      if (this.props.onDocSelected !== undefined && this.props.onDocSelected != null && typeof this.props.onDocSelected === 'function')
        this.props.onDocSelected(docId, docName, this);  
    };

    showPleaseWait = () => { this.setState({isPleaseWaitOpen: true}); }
    hidePleaseWait = () => { this.setState({isPleaseWaitOpen: false}); }
  
    render() {
        const need2Lines = 30;
        const need3Lines = 60;
        const nameHeight = this.product.Name.length > 40 ? 36: 24;
        const manufacturerHeight = this.product.Manufacturer.length > need2Lines ? 34: 22;
        const ingredientHeight = this.product.Ingredient.length > need3Lines ? 46 : this.product.Ingredient.length > need2Lines ? 34: 22;
        const targetPestHeight = this.product.TargetPests.length > need3Lines ? 46 : this.product.TargetPests.length > need2Lines ? 34: 22;
        const cardHeight = 252 
          + (this.product.Name.length > 40 ? 12 : 0) 
          + (this.product.Manufacturer.length > need2Lines ? 12 : 0) 
          + (this.product.Ingredient.length > need3Lines ? 24 : this.product.Ingredient.length > need2Lines ? 12 : 0) 
          + (this.product.TargetPests.length > need3Lines ? 24 : this.product.TargetPests.length > need2Lines ? 12 : 0);
        const cardWidth = parseInt(Dimensions.get('window').width) - 24;
        return (
        <View style={{height: cardHeight, width: cardWidth, position: "relative"}}>
          <View
            style={{
              height: cardHeight, width: cardWidth, position: "absolute", top: 0, left: 0, 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 4, marginTop: 0, padding: 4,
              backgroundColor: "#ffffff",
              fontSize: 10
            }}
          >
            <View style={{flexDirection: 'row', height: nameHeight, borderWidth: 1, borderColor: "#ff0000", backgroundColor: "#cccccc", paddingTop: 4}}>
              <Text style={[styles.dataField, {fontWeight: "bold", color: "#ff0000", width: "100%", textAlign: 'center', paddingLeft: 8, paddingRight: 8 }]}>{this.product.Name.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: manufacturerHeight, paddingTop: 2}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Manufactory').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.Manufacturer.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('ProdPCP#').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.PCP.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSRevision#').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.RevisionNumber.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: ingredientHeight}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSIngredient').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.Ingredient.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSLocation').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.Location.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSPesticideClass').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.PesticideClass.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSFormulationType').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.FormulationType.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: targetPestHeight}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('SDSTargetPest').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.product.TargetPests.toUpperCase()}</Text>
            </View>
            <View style={{flexDirection: 'row', height: 46, borderTopWidth: 1, borderColor: "#ff0000"}}>
              <View style={{width: '50%', alignItems: 'center'}}>
                  <Button
                    disabled = {!this.hasLabel} 
                    title={'  ' + TextString.Get('SDSLabel').toUpperCase()}
                    titleStyle={{ fontSize: 16, color: '#333333' }}
                    icon={{ name: 'tag', type: 'font-awesome', size: 16, color: '#666666', }}
                    iconContainerStyle={{ marginRight: 6 }}
                    buttonStyle={{ backgroundColor: '#cccccc', borderColor: "#666666", borderWidth: 1, borderRadius: 8}}
                    type="solid"
                    containerStyle={{ width: 150, paddingTop: 4}}
                    onPress={() => { this.onDocSelected(this.product.LabelDocId, this.product.LabelDocName); }}
                  />
              </View>
              <View style={{width: '50%', alignItems: 'center'}}>
                  <Button 
                    disabled = {!this.hasSDS} 
                    title={'  ' + TextString.Get('SDS').toUpperCase()}
                    titleStyle={{ fontSize: 16, color: '#333333' }}
                    icon={{ name: 'warning', type: 'font-awesome', size: 16, color: '#666666', }}
                    iconContainerStyle={{ marginRight: 6 }}
                    buttonStyle={{ backgroundColor: '#cccccc', borderColor: "#666666", borderWidth: 1, borderRadius: 8}}
                    type="solid"
                    containerStyle={{ width: 150, paddingTop: 4 }}
                    onPress={() => { this.onDocSelected(this.product.SDSDocId, this.product.SDSDocName); }}
                  />
              </View>
            </View>
          </View>
          {
            this.state.isPleaseWaitOpen
            &&
            <View 
              style={{
                height: cardHeight, width: cardWidth, position: "absolute", top: 0, left: 0, 
                flex: 1, alignItems: 'center', justifyContent: 'space-evenly', alignSelf: 'stretch',
                borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
                marginLeft: 4, marginTop: 2, padding: 4,
                backgroundColor: "#00000000"
              }}
            >
              <Image source={require('../../assets/oc/LadyBug.gif')} style={{ width: 40, height: 40, }} />
            </View>
          }
        </View>
      );
    }
  }
    
  const styles = StyleSheet.create({
    dataFieldCaption: {
      width: 130,
      fontSize: 10, 
      fontWeight: "bold", 
      color: "#666666",
      paddingTop: 2,
    },
    dataField: {
      flex: 1, 
      fontSize: 12, 
    }
  });

  export default LabelSdsCard;