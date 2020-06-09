import axios from 'axios'
import { config } from './config'

export const userService = {
    login,
    logout,
    register,
    getAll,
    getById,
    update,
    delete: _delete
}

async function login(username, password) {
    const data = JSON.stringify({Email: username, Password: password})
    return await axios.post(`${config.apiUrl}/users/authenticate`, data, { headers: config.headers })
        .then(user => {
            console.log(user)
            localStorage.setItem('user', JSON.stringify(user))
            return user
        })
}

function logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('user')
}

async function register(user) {
    const data = JSON.stringify(user)
    return await axios.post(`${config.apiUrl}/users/`, data, {headers: config.headers})
        .then(user => {
            return user
        })
}

async function getAll() {
    return await axios.get(`${config.apiUrl}/users`, {headers: config.headers})
        .then(users => {return users})
}


async function getById(id) {
    return await axios.get(`${config.apiUrl}/users/${id}`, {headers: config.headers})
        .then(user => {return user})
}

async function update(user) {
    return await axios.put(`${config.apiUrl}/users/${user.id}`, JSON.stringify(user), {headers: config.headers})
        .then(user => {return user})
}

// prefixed function name with underscore because delete is a reserved word in javascript
async function _delete(id) {
    return await axios.delete(`${config.apiUrl}/users/${id}`)
}