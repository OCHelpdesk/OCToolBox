import React, { Component } from "react";
import { TouchableWithoutFeedback, View, Text } from 'react-native';
import FontAwesome from 'react-native-vector-icons/FontAwesome';
import MaterialCommunityIcons from 'react-native-vector-icons/MaterialCommunityIcons';

import TextString from '../components/TextString';

class ProductListSetNational extends Component {
    constructor(props) {
        super(props);
        this.isPressIn = false;
        this.state = { isNationalSite: isNationalSite, title: TextString.Get('National').toUpperCase() + '?' };
        if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
          props.onCreated(this);
      }

    setIsNationalSite(isNationalSite) {
        this.setState({isNationalSite: isNationalSite, title: TextString.Get('National').toUpperCase() + (isNationalSite ? '!' : '?')});
        if (this.state.isNationalSite && this.props.onPressIn !== undefined && this.props.onPressIn != null && typeof this.props.onPressIn === 'function')
            this.props.onPressIn();
        if (!this.state.isNationalSite && this.props.onPressOut !== undefined && this.props.onPressOut != null && typeof this.props.onPressOut === 'function')
            this.props.onPressOut();
    }

    render() {
        return (
            <View style = {[this.props.style, {flexDirection: "row", textAlign: "center", alignItems: 'center', justifyContent: 'center', margin: 0, padding: 0}]}>
                {
                this.state.isNationalSite
                &&    
                <FontAwesome name="check-square-o" size={this.props.iconSize} color={this.props.iconColor} style={{marginTop: 1}} />
                }
                {
                !this.state.isNationalSite
                &&    
                <MaterialCommunityIcons name="account-question" size={this.props.iconSize} color={this.props.iconColor} style={{marginTop: 1}} />
                }
                <TouchableWithoutFeedback
                    onPressIn={() => { 
                        this.isPressIn = true;
                        this.setIsNationalSite(true)
                    }}
                    onPressOut={() => {
                        this.isPressIn = false;
                        this.setIsNationalSite(false); 
                    }}>
                    <Text style={this.props.fontStyle} >{this.state.title}</Text>
                </TouchableWithoutFeedback>
            </View>
        );
    }
}

export default ProductListSetNational;