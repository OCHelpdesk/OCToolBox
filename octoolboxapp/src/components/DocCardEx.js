import React, { Component } from "react"
import {StyleSheet, Text, TouchableOpacity, View, Image, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import IconEx from 'react-native-vector-icons/MaterialCommunityIcons';
import { Button } from '@rneui/base';
import TextString from './TextString';


class DocCardEx extends Component {

    constructor(props) {
      super(props);
      this.state = { isPleaseWaitOpen: false };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onDocSelected = () => {
      if (this.props.onDocSelected !== undefined && this.props.onDocSelected != null && typeof this.props.onDocSelected === 'function')
        this.props.onDocSelected(this.props.doc.Id, this);  
    };

    showPleaseWait = () => { this.setState({isPleaseWaitOpen: true}); }
    hidePleaseWait = () => { this.setState({isPleaseWaitOpen: false}); }
  
    render() {
        const cardHeight = 140;
        const cardWidth = parseInt(Dimensions.get('window').width) - 24;
        return (
        <View style={{height: cardHeight, width: cardWidth, position: "relative"}}>
          <TouchableOpacity
            style={{
              height: cardHeight, width: cardWidth, position: "absolute", top: 0, left: 0, 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 4, marginTop: 0, padding: 4,
              backgroundColor: "#ffffff",
              fontSize: 10
            }}
            onPress={this.onDocSelected}
          >
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Category').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.props.doc.Category.toUpperCase()}</Text>
              <Icon name={this.props.doc.IconName} size={16} color={this.props.doc.IconColor} style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Subcategory').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.props.doc.Subcategory.toUpperCase()}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row', height: 22}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Name').toUpperCase()}</Text>
              <Text style={[styles.dataField, {fontWeight: "bold", color: "#ff0000", }]}>{this.props.doc.Name.toUpperCase()}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Description').toUpperCase()}</Text>
              <Text style={styles.dataField}>{this.props.doc.SizeKB}KB, {this.props.doc.DateLastUpdated}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>{' '}</Text>
              <Text style={styles.dataField}>{this.props.doc.Description}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
          </TouchableOpacity>
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
      width: 100,
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

  export default DocCardEx;
