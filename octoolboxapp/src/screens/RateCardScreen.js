import React, { Component } from "react"
import { TouchableWithoutFeedback, Image, Dimensions } from 'react-native';
import ImageZoom from 'react-native-image-pan-zoom';
import RNFS from 'react-native-fs';

import TextString from '../components/TextString';
import { createIconSetFromFontello } from "react-native-vector-icons";

class RateCardScreen extends Component {
  static ServiceRateCards = [];
  static GetCommercialRateCardType = () => {
    return 'Commercial' + (global.isInPreviewMode ? "Preview" : "") + (TextString.IsInFrench() ? "Fr" : "En")
  }
  static GetResidentialRateCardType = () => {
    return 'Residential' + (global.isInPreviewMode ? "Preview" : "") + (TextString.IsInFrench() ? "Fr" : "En")
  }
  static GetRateCardFilePath = (ratecardtype) => {
    for (var i = 0; i < RateCardScreen.ServiceRateCards.length; i++) {
      if (RateCardScreen.ServiceRateCards[i].RateCardType == ratecardtype) {
        return RNFS.DocumentDirectoryPath + '/' + ratecardtype + RateCardScreen.ServiceRateCards[i].VersionNumber + '.' + RateCardScreen.ServiceRateCards[i].ImageType;
      }
    }
    return null;
  }

  removeDownloadedRateCards = async () => {
    console.log('Remove Downloaded Rate Cards'); 
    const arrayOfReadDirItem = await RNFS.readDir(RNFS.DocumentDirectoryPath);
    //console.log('Iterate through files in the temp folder, unlink old ones');
    for (var i = 0; i < arrayOfReadDirItem.length; i++) {
      //if is file and created 24 hours ago, removed it
      if (arrayOfReadDirItem[i].isFile && (arrayOfReadDirItem[i].name.indexOf('Commercial') >= 0 || arrayOfReadDirItem[i].name.indexOf('Residential') >= 0)) {
        console.log("Remove " + RNFS.DocumentDirectoryPath + "/" + arrayOfReadDirItem[i].name);
        await RNFS.unlink(RNFS.DocumentDirectoryPath + "/" + arrayOfReadDirItem[i].name);
      }
    }
  }

  constructor(props) {
    super(props);
    this.navigation = props.navigation;
    this.ratecardtype = props.route.ratecardtype != null ? props.route.ratecardtype : props.route.params.ratecardtype;
    this.ratecard = null;
    for (var i = 0; i < RateCardScreen.ServiceRateCards.length; i++) {
      if (RateCardScreen.ServiceRateCards[i].RateCardType == this.ratecardtype) {
        this.ratecard = RateCardScreen.ServiceRateCards[i];
        break;
      }
    }
    this.imgFile = RNFS.DocumentDirectoryPath + '/' + this.ratecard.RateCardType + this.ratecard.VersionNumber + '.' + this.ratecard.ImageType;
    this.screenWidth = parseInt(Dimensions.get('window').width);
    this.screenHeight = parseInt(Dimensions.get('window').height);
    this.imgWidth = this.ratecard.Width; 
    this.imgHeight = this.ratecard.Height;
    this.imgScale = this.screenWidth / this.imgWidth;
    this.imgViewWidth = this.screenWidth;
    this.imgViewHeight = parseInt(this.imgHeight * this.imgScale + '');
    this.centerOnX = (this.imgWidth - this.screenWidth) / 2;
    this.centerOnY = (this.imgHeight - this.screenHeight) / 2;
    this.timeLogoLastPressed = new Date().getTime();
    const screenTitle = this.ratecardtype.indexOf('Comm') >= 0 ? TextString.Get('CommService').toUpperCase() : TextString.Get('ResiService').toUpperCase();
    setTimeout(() => {
      this.navigation.setOptions({ title: screenTitle });
    }, 200);
    if (global.isInPreviewMode) {
      setTimeout(() => {
        this.removeDownloadedRateCards();
      }, 2000);
    }
  }

  render() {
    return (
      <ImageZoom
        cropWidth={this.screenWidth}
        cropHeight={this.screenHeight}
        imageWidth={this.imgWidth}
        imageHeight={this.imgHeight}
        enableCenterFocus={false}
        centerOn={{x: this.centerOnX, y: this.centerOnY, scale: 1, duration: 0.1}}
      >
        <Image 
          style={{width: this.imgViewWidth, height: this.imgViewHeight}}
          source={{uri: this.imgFile}}
        />
      </ImageZoom>        
    )
  }
}
  
export default RateCardScreen