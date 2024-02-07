import React, { Component } from 'react';
import { View, Dimensions } from 'react-native';
import { Button } from '@rneui/base';
import { CommonActions } from "@react-navigation/native";
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

  onPlayerStateChanged = (playerState) => {
    if (playerState === 'ended') {
      this.setState({isPlaying: false});
    }
    else if (playerState === 'playing') {
      this.setState({isPlaying: true});
    }
    else if (playerState === 'paused') {
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
      <View style={{ height: '100%', flexDirection: "column", alignItems: 'flex-start', backgroundColor: '#333333',}}>
        <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
        <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
        <View style={{flex: 1, alignItems: 'center', justifyContent: 'center',  alignSelf: 'stretch', backgroundColor: '#333333',}}>
          <YoutubePlayer
              ref={this.player}
              height={playerHeight}
              width={screenWidth}
              play={this.state.isPlaying}
              videoId={this.YouTubeVideoId}
              onChangeState={this.onPlayerStateChanged}
            />
        </View>
        <View style={{height: 4, width: '100%', backgroundColor: "#333333"}} />
        <View style={{height: 2, width: '100%', backgroundColor: "#663333"}} />
        <View style={{height: 2, width: '100%', backgroundColor: "#993333"}} />
        <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
        <View style={{flexDirection: 'row', alignItems: 'flex-start', justifyContent: 'center', height: 40, width: '100%', backgroundColor: '#333333', marginBottom: 12,}}>
            <View style={[{width: "50%"}]}>
              <Button 
                title={TextString.Get('Home').toUpperCase()}
                titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                icon={{ name: 'home', type: 'font-awesome', size: 16, color: '#ffffff', }}
                iconContainerStyle={{ marginRight: 6 }}
                buttonStyle={{ backgroundColor: '#333333', }}
                onPress={() => { this.navigation.dispatch(CommonActions.reset({index: 0, routes: [{ name: "AppHome" }]})); }}
              />
            </View>
            <View style={[{width: "20%"}]}>
              <Button
                title=''
                titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                disabled = {this.state.isPlaying}
                disabledStyle = {{ backgroundColor: '#333333' }}
                icon={{ name: 'play', type: 'font-awesome', size: 16, color: this.state.isPlaying ? "#666666" : "#ffffff", }}
                iconContainerStyle={{ marginRight: 6 }}
                buttonStyle={{ backgroundColor: '#333333', }}
                onPress={() => { this.togglePlaying(); }}
              />
            </View>
            <View style={[{width: "30%"}]}>
              <Button 
                title=''
                titleStyle={{ fontSize: 16, fontWeight: 'bold', color: '#ffffff' }}
                disabled = {!this.state.isPlaying}
                disabledStyle = {{ backgroundColor: '#333333' }}
                icon={{ name: 'pause', type: 'font-awesome', size: 16, color: this.state.isPlaying ? "#ffffff" : "#666666", }}
                iconContainerStyle={{ marginRight: 6 }}
                buttonStyle={{ backgroundColor: '#333333', }}
                onPress={() => { this.togglePlaying(); }}
              />
            </View>
        </View>
        <View style={{height: 1, width: '100%', backgroundColor: "#ff0000"}} />
      </View>      
    )
  }
}

export default YouTubeScreen
