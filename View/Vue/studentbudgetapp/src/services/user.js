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
        .then(handleResponse)
        .then(user => {
            localStorage.setItem('user', JSON.stringify(user))
            return user
        })
}

function logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('user')
}

async function register(user) {
    return await axios.post(`${config.apiUrl}/users/register`, JSON.stringify(user), {headers: config.headers})
        .then(handleResponse)
}

async function getAll() {
    return await axios.get(`${config.apiUrl}/users`, {headers: config.headers}).then(handleResponse)
}


async function getById(id) {
    return await axios.get(`${config.apiUrl}/users/${id}`, {headers: config.headers}).then(handleResponse)
}

async function update(user) {
    return await axios.put(`${config.apiUrl}/users/${user.id}`, JSON.stringify(user), {headers: config.headers}).then(handleResponse)
}

// prefixed function name with underscore because delete is a reserved word in javascript
async function _delete(id) {
    return await axios.delete(`${config.apiUrl}/users/${id}`).then(handleResponse)
}

function handleResponse(response) {
    return response.text().then(text => {
        const data = text && JSON.parse(text)
        if (!response.ok) {
            if (response.status === 401) {
                // auto logout if 401 response returned from api
                logout()
                location.reload(true)
            }

            const error = (data && data.message) || response.statusText
            return Promise.reject(error)
        }

        return data
    })
}