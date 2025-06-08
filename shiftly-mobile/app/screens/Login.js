import React, { useState } from 'react';
import { View, TextInput, Button, StyleSheet, Text } from 'react-native';

export default function Login({ navigation }) {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    const onLogin = () => {
        // TODO: Integracja z backendem
        navigation.replace('Dashboard');
    };

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Shiftly Login</Text>
            <TextInput
                placeholder="Email"
                style={styles.input}
                value={email}
                onChangeText={setEmail}
                autoCapitalize="none"
            />
            <TextInput
                placeholder="Password"
                secureTextEntry
                style={styles.input}
                value={password}
                onChangeText={setPassword}
            />
            <Button title="Login" onPress={onLogin} />
        </View>
    );
}

const styles = StyleSheet.create({
    container: { flex: 1, justifyContent: 'center', padding: 20 },
    input: {
        borderWidth: 1,
        borderColor: '#666',
        padding: 10,
        marginBottom: 15,
        borderRadius: 5,
    },
    title: { fontSize: 24, marginBottom: 20, textAlign: 'center' },
});
