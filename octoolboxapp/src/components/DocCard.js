import React, { Component } from "react"
import {StyleSheet, Text, TouchableOpacity, View, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import IconEx from 'react-native-vector-icons/MaterialCommunityIcons';
import { Button } from '@rneui/base';
import TextString from './TextString';


class DocCard extends Component {

    constructor(props) {
      super(props);
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onDocSelected = () => {
      if (this.props.onDocSelected !== undefined && this.props.onDocSelected != null && typeof this.props.onDocSelected === 'function')
        this.props.onDocSelected(this.props.doc.Id);  
    };
  
    render() {
        const screenHeight = parseInt(Dimensions.get('window').height);
        return (
        <View>
          <TouchableOpacity
            style={{
              height: 130, 
              width: '100%', 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 4, marginTop: 2, padding: 4,
              backgroundColor: "#ffffff"
            }}
            onPress={this.onDocSelected}
          >
            <View style={{flexDirection: 'row', height: 24}}>
              <Text style={styles.dataFieldCaption}>{'Category:'.toUpperCase()}</Text>
              <Text style={{flex: 1, }}>{this.props.doc.Category.toUpperCase()}</Text>
              <Icon name={this.props.doc.IconName} size={16} color={this.props.doc.IconColor} style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row', height: 24}}>
              <Text style={styles.dataFieldCaption}>{'Name:'.toUpperCase()}</Text>
              <Text style={{flex: 1, }}>{this.props.doc.Name.toUpperCase()}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>{'Description:'.toUpperCase()}</Text>
              <Text style={{flex: 1, }}>{this.props.doc.SizeKB}KB, {this.props.doc.DateLastUpdated}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>{' '}</Text>
              <Text style={{flex: 1, }}>{this.props.doc.Description}</Text>
              <Icon name='circle-thin' size={16} color='#ffffff' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
          </TouchableOpacity>
        </View>
      );
    }
  }
    
  const styles = StyleSheet.create({
    dataFieldCaption: {
      width: 100,
      fontSize: 12, 
      fontWeight: "bold", 
      color: "#666666",
      paddingTop: 2,
    }
  });

  export default DocCard;
