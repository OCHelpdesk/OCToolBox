import * as React from 'react';
import { Image, Dimensions } from 'react-native';
import ImageZoom from 'react-native-image-pan-zoom';

import TextString from '../components/TextString';

const RateCardCommercialServiceScreen = ({navigation, route}) => {
    const screenTitle = TextString.Get('CommService').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
    }, 200);
    var screenWidth = parseInt(Dimensions.get('window').width);
    var screenHeight = parseInt(Dimensions.get('window').height) - 80;
    const imgWidth = 592, imgHeight = 2050;
    //var imgViewWidth = parseInt((imgWidth * (screenHeight / imgHeight)) + '');
    //var imgViewHeight = screenHeight;
    var imgScale = screenWidth / imgWidth;
    var imgViewWidth = screenWidth;
    var imgViewHeight = parseInt(imgHeight * imgScale + '');
    return (
        <ImageZoom
            cropWidth={screenWidth}
            cropHeight={screenHeight}
            imageWidth={imgWidth}
            imageHeight={imgHeight}
            enableCenterFocus={false}
            centerOn={{x: 100, y: 646, scale: 1, duration: 0.1}}
            >
            {
              TextString.IsInFrench()
              &&
              <Image 
                style={{width: imgViewWidth, height: imgViewHeight}}
                source={require('../../assets/oc/RC2024CommFr.png')}
              />
            }
            {
              !TextString.IsInFrench()
              &&
              <Image 
                style={{width: imgViewWidth, height: imgViewHeight}}
                source={require('../../assets/oc/RC2024CommEn.png')}
              />
            }
        </ImageZoom>
    );
  };
  
export default RateCardCommercialServiceScreen