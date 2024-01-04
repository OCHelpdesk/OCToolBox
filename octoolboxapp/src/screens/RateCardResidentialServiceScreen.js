import * as React from 'react';
import { Image, Dimensions } from 'react-native';
import ImageZoom from 'react-native-image-pan-zoom';

import TextString from '../components/TextString';

const RateCardResidentialServiceScreen = ({navigation, route}) => {
    const screenTitle = TextString.Get('ResiService').toUpperCase();
    setTimeout(() => {
      navigation.setOptions({ title: screenTitle });
    }, 200);
    const screenWidth = parseInt(Dimensions.get('window').width);
    const screenHeight = parseInt(Dimensions.get('window').height) - 80;
    const imgWidth = 592, imgHeight = 1480;
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
            centerOn={{x: 100, y: 360, scale: 1, duration: 0.1}}
            >
            {
              TextString.IsInFrench()
              &&
              <Image 
                style={{width: imgViewWidth, height: imgViewHeight}}
                source={require('../../assets/oc/RC2024ResiFr.png')}
              />
            }
            {
              !TextString.IsInFrench()
              &&
              <Image 
                style={{width: imgViewWidth, height: imgViewHeight}}
                source={require('../../assets/oc/RC2024ResiEn.png')}
              />
            }
        </ImageZoom>
    );
  };
  
export default RateCardResidentialServiceScreen