import React from 'react';
import { StyleSheet, Text, View} from 'react-native';

export default function Header() {
    return (
        <View style={styles.headerr}>
            <Text style={styles.todo}>Todos List</Text>
        </View>
    );
}


const styles=StyleSheet.create({
     headerr:{
         backgroundColor:'blue',
         height:100,
         paddingTop:35
     },
     todo:{
         textAlign:"center",
         color:"white",
         fontSize:20,
         fontWeight:"bold",

     },
});
