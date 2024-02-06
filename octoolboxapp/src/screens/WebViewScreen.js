import React, { Component } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import { WebView } from 'react-native-webview';


class VideoListScreen extends Component {
  constructor(props) {
    super(props);
    this.navigation = props.navigation;
    this.URL = props.route.params.URL;
    this.screenTitle = props.route.params.title;
    setTimeout(() => {
      this.navigation.setOptions({ title: this.screenTitle });
    }, 200);
  }

  render() {
    return (
      <WebView source={{ uri: this.URL }} style={{ flex: 1 }} />
    )
  }
}

export default VideoListScreen
