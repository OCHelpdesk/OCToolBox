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
              height: 100, 
              width: '100%', 
              borderWidth: 0, borderColor: "#ff0000", borderRadius: 5, 
              marginLeft: 4, marginTop: 2, padding: 4,
              backgroundColor: "#ffffff"
            }}
            onPress={this.onDocSelected}
          >
            <View style={{flexDirection: 'row', height: 24}}>
              <Text style={styles.dataFieldCaption}>Category:</Text>
              <Text style={{flex: 1, }}>{this.props.doc.DocCategory}</Text>
              <Icon name='file-pdf-o' size={16} color='#ff0000' style={{width: 24, textAlign: "center", textAlignVertical: "top"}}/>
            </View>
            <View style={{flexDirection: 'row', height: 24}}>
              <Text style={styles.dataFieldCaption}>Name:</Text>
              <Text style={{flex: 1, }}>{this.props.doc.DocName}</Text>
            </View>
            <View style={{flexDirection: 'row'}}>
              <Text style={styles.dataFieldCaption}>Description:</Text>
              <Text style={{flex: 1, }}>{this.props.doc.DocDescription}</Text>
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
