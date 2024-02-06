import React, { Component } from "react"
import {StyleSheet, Text, TouchableOpacity, View, Image, Dimensions } from "react-native";
import Icon from 'react-native-vector-icons/FontAwesome';
import IconEx from 'react-native-vector-icons/MaterialCommunityIcons';
import { Button } from '@rneui/base';
import TextString from './TextString';


class VideoCard extends Component {

    constructor(props) {
      super(props);
      this.state = { isPleaseWaitOpen: false };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onVideoSelected = () => {
      if (this.props.onVideoSelected !== undefined && this.props.onVideoSelected != null && typeof this.props.onVideoSelected === 'function')
        this.props.onVideoSelected(this.props.video.URL, this);  
    };

    showPleaseWait = () => { this.setState({isPleaseWaitOpen: true}); }
    hidePleaseWait = () => { this.setState({isPleaseWaitOpen: false}); }
  
    render() {
        const imgHeight = 90;
        const imgBoxHeight = imgHeight + 8;
        const imgWidth = 120;
        const imgBoxWidth = imgWidth + 8;
        const descriptionHeight = 60;
        const cardHeight = imgBoxHeight + descriptionHeight;
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
            onPress={this.onVideoSelected}
          >
            <View style={{flexDirection: 'row', height: imgBoxHeight}}>
              <View style={{width: imgBoxWidth, height: imgBoxHeight, backgroundColor: '#ffffff', padding: 4}}>
                <Image source={{uri: this.props.video.ThumbnailURL}} style={{ height: imgHeight}} />
              </View>
              <View>
                <Text style={styles.dataFieldCaption}>{TextString.Get('Category').toUpperCase()}:</Text>
                <Text style={styles.dataField}>{this.props.video.Category.toUpperCase()}</Text>
                <Text style={styles.dataFieldCaption}>{TextString.Get('Subcategory').toUpperCase()}:</Text>
                <Text style={styles.dataField}>{this.props.video.Subcategory.toUpperCase()}</Text>
                <Text style={styles.dataFieldCaption}>{TextString.Get('Name').toUpperCase()}:</Text>
                <Text style={styles.dataField}>{this.props.video.Name.toUpperCase()}</Text>
              </View>
            </View>
            <View style={{height: descriptionHeight}}>
              <Text style={styles.dataFieldCaption}>{TextString.Get('Description').toUpperCase()}:</Text>
              <Text style={styles.dataField}>{this.props.video.Description}</Text>
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
      height: 16,
      fontSize: 10, 
      fontWeight: "bold", 
      color: "#666666",
      paddingTop: 2,
      paddingLeft: 4,
      paddingRight: 4 
    },
    dataField: {
      height: 16,
      fontSize: 12, 
      paddingLeft: 4,
      paddingRight: 4 
    }
  });

  export default VideoCard;
