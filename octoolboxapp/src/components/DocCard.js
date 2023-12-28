import React, { Component } from "react"
import {StyleSheet, Text, TouchableOpacity, View, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
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
        this.props.onDocSelected(this.props.doc.DocId);  
    };
  
    render() {
        const screenHeight = parseInt(Dimensions.get('window').height);
        return (
        <View>
          <TouchableOpacity
            style={{
              height: 80, 
              width: '100%', 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 4, marginTop: 2, padding: 4,
              backgroundColor: "#ffffff"
            }}
            onPress={this.onDocSelected}
          >
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>Doc. Name:</Text>
              <Text style={{flex: 1, }}>{this.props.doc.DocName}</Text>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>Description:</Text>
              <Text style={{flex: 1, }}>{this.props.doc.DocName}</Text>
            </View>
          </TouchableOpacity>
        </View>
      );
    }
  }
    
  const styles = StyleSheet.create({
    dataFieldCaption: {
      width: 80,
      fontSize: 12, 
      fontWeight: "bold", 
      color: "#666666",
      paddingTop: 2,
    }
  });

  export default DocCard;
