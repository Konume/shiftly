import React from 'react';
import { View, Text, Button, StyleSheet } from 'react-native';

export default function Dashboard({ navigation }) {
    return (
        <View style={styles.container}>
            <Text style={styles.title}>Witaj w Shiftly!</Text>
            <Button title="Mój grafik" onPress={() => navigation.navigate('ShiftCalendar')} />
            <Button title="Wnioski urlopowe" onPress={() => navigation.navigate('LeaveRequests')} />
            <Button title="Proœby o zamianê" onPress={() => navigation.navigate('SwapRequests')} />
        </View>
    );
}

const styles = StyleSheet.create({
    container: { flex: 1, justifyContent: 'center', padding: 20 },
    title: { fontSize: 24, marginBottom: 20, textAlign: 'center' },
});
