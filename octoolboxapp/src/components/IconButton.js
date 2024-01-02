import React, { Component } from "react";
import { Button } from '@rneui/base';

class IconButton extends Component {
    constructor(props) {
        super(props);
        this.state = { icon: props.icon, title: props.title };
        if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
          props.onCreated(this);
      }
    changeIcon(newIcon) {
        this.setState({ icon: newIcon });
    } 
    changeTitle(newTitle) {
        this.setState({ title: newTitle });
    } 
    changeState(newIcon, newTitle) {
        this.setState({ icon: newIcon, title: newTitle });
    } 
    render() {
        return (
          <Button 
            title={this.state.title}
            titleStyle={this.props.titleStyle}
            icon={this.state.icon}
            iconContainerStyle={this.props.iconContainerStyle}
            buttonStyle={this.props.buttonStyle}
            onPress={this.props.onPress}
          />
        );
      }
}

export default IconButton;