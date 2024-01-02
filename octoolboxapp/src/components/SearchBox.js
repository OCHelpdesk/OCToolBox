import React, { Component } from "react"
import { Modal, View, TextInput, TouchableOpacity, Text } from "react-native"
import { Button } from '@rneui/base';
import FontAwesome from 'react-native-vector-icons/FontAwesome';

class SearchBox extends Component {
    constructor(props) {
      super(props);
      var defaultValue = props.defaultValue !== undefined ? props.defaultValue : null;
      this.state = { searchTerm: defaultValue, isAdvanceBoxShowing: false };
      if (props.onCreated !== undefined && props.onCreated != null && typeof props.onCreated === 'function')
        props.onCreated(this);
    }

    onSearchButtonClicked = (searchFields) => {
        if (this.state.searchTerm == null || this.state.searchTerm.trim() == '') {
            alert('Please enter a search term.');
            return;
        }
        if (this.props.onSearchButtonClicked !== undefined && this.props.onSearchButtonClicked != null && typeof this.props.onSearchButtonClicked === 'function') {
            this.props.onSearchButtonClicked(this.state.searchTerm, searchFields);  
        }
    }

    switchToAdvancedSearch = () => {
        this.setState({ isAdvanceBoxShowing: true });
    }
  
    render() {
      return (
        <View style={[this.props.style, {flex: 3, height: 32, flexDirection: "row"}]}>
            <Modal visible={this.state.isAdvanceBoxShowing} transparent={true}>
                <View style={{backgroundColor: "#000000cc", flex: 1}}>
                <View 
                    style={{
                    backgroundColor: "#ffffff", 
                    height: 300, 
                    marginTop: 150, marginLeft: 50, marginRight: 50, padding: 8,
                    borderWidth: 1, borderColor: "#ff0000", borderRadius: 5,
                    }}>
                    <TouchableOpacity
                        style={{flexDirection: "row", borderBottomWidth: 1, borderBottomColor: "#333333", paddingBottom: 4}}
                        onPress={() => {this.setState({isAdvanceBoxShowing: false})}}
                    >
                        <Text style={{flex: 1, alignSelf: 'stretch', fontWeight: "bold", color: "#333333", paddingTop: 4}}>ADVANCED SEARCH</Text>
                        <FontAwesome name="close" size={24} color="#666666" style={{flex: 0, width: 24, }} />
                    </TouchableOpacity>
                    <View style={{flex: 1, alignItems: 'center', justifyContent: 'center', alignSelf: 'stretch', backgroundColor: '#ffffff',}}>
                        <Text>UNDER CONSTRUCTION</Text>
                    </View>
                </View>
                </View>
            </Modal>
            <TextInput 
                ref={input => { this.textInput = input }}
                style={{flex: 1, paddingLeft: 8 }} 
                defaultValue={this.props.defaultValue} 
                placeholder={this.props.placeholder}
                onChangeText={(newText) => { this.setState({searchTerm: newText}); }}
                returnKeyType='search'
                onSubmitEditing={() => { this.onSearchButtonClicked(); }}
            />
            <Button 
                title=''
                titleStyle={{ color: '#666666', fontWeight: "bold" }}
                icon={{ name: 'search', type: 'font-awesome', size: 24, color: '#666666', }}
                type="clear" 
                buttonStyle={{ width: 60, margin: 2 }}
                onPress={() => { /*this.textInput.clear();*/ this.onSearchButtonClicked(); }}
            />
            </View>
        );
    }
  }
  
export default SearchBox;
