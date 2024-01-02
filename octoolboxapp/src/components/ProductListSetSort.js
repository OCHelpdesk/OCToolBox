import React, { Component } from "react";
import {  Modal, TouchableOpacity, View, Text, Dimensions } from 'react-native';
import { Button } from '@rneui/base';
import Icon from 'react-native-vector-icons/FontAwesome';

import TextString from '../components/TextString';

class ProductListSetSort extends Component {
    constructor(props) {
        super(props);
        this.init = {sortFavoritesOnTop: true, sortField: props.sortField === undefined || props.sortField == null ? 'Name' : props.sortField };
        this.state = { sortFavoritesOnTop: true, sortField: this.init.sortField, isSortSelectionBoxShowing: false };
        if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
          props.onCreated(this);
      }

    render() {
        const screenHeight = parseInt(Dimensions.get('window').height);
        const sortSelectionBoxHeight = 338;
        const sortSelectionBoxMarginTop = (screenHeight - sortSelectionBoxHeight) / 2;
        return (
          <View>
            <Modal visible={this.state.isSortSelectionBoxShowing} transparent={true}>
            <View style={{backgroundColor: "#000000cc", flex: 1}}>
                <View 
                style={{
                    height: sortSelectionBoxHeight, 
                    marginRight: 50, marginLeft: 50, marginTop: sortSelectionBoxMarginTop,
                    padding: 8,
                    backgroundColor: "#333333",
                    borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                }}>
                <TouchableOpacity
                    style={{flexDirection: "row", borderBottomWidth: 1, borderBottomColor: "#333333"}}
                    onPress={() => { 
                        this.setState({ sortFavoritesOnTop: this.init.sortFavoritesOnTop, sortField: this.init.sortField, isSortSelectionBoxShowing: false }); 
                    }}
                >
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 12, fontWeight: "bold", color: "#ffffff", paddingTop: 4}}>{TextString.Get('ProdChooseFieldToSort').toUpperCase()}</Text>
                    <Icon name="close" size={22} color="#ffffff" style={{flex: 0, width: 22, }} />
                </TouchableOpacity>
                <View style={{height: 2, borderBottomWidth: 1, borderBottomColor: "#ff0000", paddingBottom: 8, alignItems: 'center'}}></View>
                <View style={{flexDirection: "column",}}>
                    <TouchableOpacity style={{flexDirection: "row", paddingTop: 20,}} onPress={() => { this.setState({sortField: 'Category'}); } }>
                    <View style={{width: 60}}>
                        {
                        this.state.sortField == 'Category'
                        &&
                        <Icon name="dot-circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                        {
                        this.state.sortField != 'Category'
                        &&
                        <Icon name="circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                    </View>
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 14, fontWeight: "bold", color: "#ffffff"}}>{TextString.Get('Category').toUpperCase()}</Text>
                    </TouchableOpacity>
                    <TouchableOpacity style={{flexDirection: "row", paddingTop: 20,}} onPress={() => { this.setState({sortField: 'Name'}); } }>
                    <View style={{width: 60}}>
                        {
                        this.state.sortField == 'Name'
                        &&
                        <Icon name="dot-circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                        {
                        this.state.sortField != 'Name'
                        &&
                        <Icon name="circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                    </View>
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 14, fontWeight: "bold", color: "#ffffff"}}>{TextString.Get('ProdName').toUpperCase()}</Text>
                    </TouchableOpacity>
                    <TouchableOpacity style={{flexDirection: "row", paddingTop: 20,}} onPress={() => { this.setState({sortField: 'ProductId'}); } }>
                    <View style={{width: 60}}>
                        {
                        this.state.sortField == 'ProductId'
                        &&
                        <Icon name="dot-circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                        {
                        this.state.sortField != 'ProductId'
                        &&
                        <Icon name="circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                    </View>
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 14, fontWeight: "bold", color: "#ffffff"}}>{TextString.Get('BOSS #').toUpperCase()}</Text>
                    </TouchableOpacity>
                    <TouchableOpacity style={{flexDirection: "row", paddingTop: 20,}} onPress={() => { this.setState({sortField: 'Vendor'}); } }>
                    <View style={{width: 60}}>
                        {
                        this.state.sortField == 'Vendor'
                        &&
                        <Icon name="dot-circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                        {
                        this.state.sortField != 'Vendor'
                        &&
                        <Icon name="circle-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20}} />
                        }
                    </View>
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 14, fontWeight: "bold", color: "#ffffff"}}>{TextString.Get('Manufactory').toUpperCase()}</Text>
                    </TouchableOpacity>
                    <View style={{height: 12, width: '100%'}} />
                    <TouchableOpacity style={{flexDirection: "row", paddingTop: 20, height: 60,}} onPress={() => { this.setState({ sortFavoritesOnTop: !this.state.sortFavoritesOnTop }); } }>
                    <View style={{width: 60}}>
                        {
                        this.state.sortFavoritesOnTop
                        &&
                        <Icon name="check-square-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20, paddingTop: 2 }} />
                        }
                        {
                        !this.state.sortFavoritesOnTop
                        &&
                        <Icon name="square-o" size={20} color="#ffffff" style={{flex: 0, textAlign: 'right', paddingRight: 20, paddingTop: 2 }} />
                        }
                    </View>
                    <Text style={{flex: 1, alignSelf: 'stretch', fontSize: 14, fontWeight: "bold", color: "#ffffff"}}>{TextString.Get('ProdFavoriteFirst').toUpperCase()}</Text>
                    </TouchableOpacity>
                </View> 
                <View style={{ borderTopWidth: 1, borderTopColor: "#ff0000", marginTop: 12, paddingTop: 4, paddingBottom: 4, alignItems: 'center'}}>
                    <Button 
                        title={'OK'}
                        titleStyle={{ fontWeight: "bold", color: "#ffffff", fontSize: 14 }}
                        type="outline" 
                        buttonStyle={{ width: 160, height: 40, borderWidth: 1, borderColor: "#ffffff", borderRadius: 20 }}
                        onPress={() => {
                            this.init = {sortFavoritesOnTop: this.state.sortFavoritesOnTop, sortField: this.state.sortField };
                            this.setState({ isSortSelectionBoxShowing: false }); 
                            if (this.props.onSorFieldChanged !== undefined && this.props.onSorFieldChanged != null && typeof this.props.onSorFieldChanged === 'function')
                                this.props.onSorFieldChanged(this.state.sortFavoritesOnTop, this.state.sortField);
                        }}
                    />
                </View>
                </View>
            </View>
            </Modal>
            <Button 
                title={TextString.Get('Sort').toUpperCase()}
                titleStyle={this.props.titleStyle}
                icon={this.props.icon}
                iconContainerStyle={this.props.iconContainerStyle}
                buttonStyle={this.props.buttonStyle}
                onPress={() => { this.setState({isSortSelectionBoxShowing: true}); }}
            />
          </View>
        );
      }
}

export default ProductListSetSort;