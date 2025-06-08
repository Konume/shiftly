import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import Login from '../screens/Login';
import Dashboard from '../screens/Dashboard';
import ShiftCalendar from '../screens/ShiftCalendar';
import LeaveRequests from '../screens/LeaveRequests';
import SwapRequests from '../screens/SwapRequests';

const Stack = createNativeStackNavigator();

export default function AppNavigator() {
    return (
        <NavigationContainer>
            <Stack.Navigator initialRouteName="Login" screenOptions={{ headerShown: false }}>
                <Stack.Screen name="Login" component={Login} />
                <Stack.Screen name="Dashboard" component={Dashboard} />
                {/*<Stack.Screen name="ShiftCalendar" component={ShiftCalendar} />*/}
                {/*<Stack.Screen name="LeaveRequests" component={LeaveRequests} />*/}
                {/*<Stack.Screen name="SwapRequests" component={SwapRequests} />*/}
            </Stack.Navigator>
        </NavigationContainer>
    );
}
