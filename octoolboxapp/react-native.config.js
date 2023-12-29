
//Refer to https://www.npmjs.com/package/react-native-vector-icons, this configuration setting is to
//void 'pod install' to create copy commands for Vector Icons as we have to copy the fonts ourselves 
//so to add the fonts to info.plist 
module.exports = {
  dependencies: {
    'react-native-vector-icons': {
      platforms: {
        ios: null,
      },
    },
  },
};