import React, { Component } from 'react';
import { View, Dimensions } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
import { WebView } from 'react-native-webview';
import YoutubePlayer from 'react-native-youtube-iframe';

import TextString from '../components/TextString';

class YouTubeScreen extends Component {
  constructor(props) {
    super(props);
    this.navigation = props.navigation;
    this.URL = props.route.params.URL;
    this.YouTubeVideoId = props.route.params.YouTubeVideoId;
    this.screenTitle = props.route.params.title;
    this.player = React.createRef();
    this.state = { isPlaying: true };
    setTimeout(() => {
      this.navigation.setOptions({ title: this.screenTitle });
    }, 200);
  }

  onChangeState = (state) => {
    if (state === 'ended') {
      this.setState({isPlaying: false});
    }
  }
  togglePlaying = () => {
    this.setState({isPlaying: !this.state.isPlaying});
  }

  render() {
    //Refer to https://lonelycpp.github.io/react-native-youtube-iframe/component-props
    //It is recommended 16:9 players are at least 480 pixels wide and 270 pixels tall.
    const screenWidth = parseInt(Dimensions.get('window').width) - 16;
    const playerHeight = screenWidth * 9 / 16;
    return (
      <View style={{flex: 1, alignItems: 'center', justifyContent: 'center', backgroundColor: '#333333',}}>
        <YoutubePlayer
            height={playerHeight}
            width={screenWidth}
            play={this.state.isPlaying}
            videoId={this.YouTubeVideoId}
            onChangeState={this.onStateChange}
          />
      </View>
    )
  }
}

export default YouTubeScreen
