import { StatusBar } from 'expo-status-bar';
import React,{useState} from 'react';
import { StyleSheet, Text, View, FlatList,Alert,Button,AsyncStorage} from 'react-native';
import Header  from './Components/header';
import TodoList from './Components/todolist';
import AddTodo from './Components/addTodo';

// import { createStackNavigator } from '@react-navigation/stack';
// import { NavigationContainer } from '@react-navigation/native';


export default function Todo({navigation}) {
  const [todos, setTodos] = useState([
    { text: 'Do Assignment', key: '1' },
    { text: 'Take a nap', key: '2' },
    { text: 'play time', key: '3' },
    {text:'DL appointment',key:'4'}
  ]);

  const pressHandler = (key) => {
    setTodos(prevTodos => {
      return prevTodos.filter(todo => todo.key != key);
    });
	alert('You have deleted one todo');
  };

  const submitHandler = (text) => {
	  if(text.length>1){
      setTodos(prevTodos => {
        return [
          { text, key: Math.random().toString() },
          ...prevTodos
        ];
	 	 })
		 alert('You have added todo');
		 }
	  else{
		  alert('OOPS! too short');
	  }
  };

  const logout=async()=>{
		await AsyncStorage.removeItem("username");
		navigation.navigate('Login');
	}
	
  return (
    // <NavigationContainer>
    <View style={styles.container}>
      <Header/>
      <View style={styles.content}>
        <AddTodo submitHandler={submitHandler}/>
        <View style={styles.list}>
        <FlatList
            data={todos}
            renderItem={({ item }) => (
              // <Text>{item.text}</Text>
              <TodoList item={item} pressHandler={pressHandler}  />
            )}
          />
        </View>
      </View>

      <Button title="Logout" onPress={logout} />
    </View>
  
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
  },
  content:{
   padding:40,
  },
  list:{
   marginTop:20,
  },
});
