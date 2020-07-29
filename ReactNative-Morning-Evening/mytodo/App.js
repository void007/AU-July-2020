import React from "react";
import {StyleSheet} from 'react-native';
import { createStackNavigator } from '@react-navigation/stack';
import { NavigationContainer } from '@react-navigation/native';

import Login from "./Login"
import Todo from './Todo';

const Stack = createStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator >
        <Stack.Screen  name="Login" component={Login} />
        <Stack.Screen  name="Todo" component={Todo} />
      </Stack.Navigator>
    </NavigationContainer>
  );
}

