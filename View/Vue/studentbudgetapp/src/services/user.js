import { authHeader } from '../helpers'

const apiUrl = 'api/'

export const userService = {
    login,
    logout,
    register,
    getAll,
    getById,
    update,
    delete: _delete
}

function login(username, password) {
    return await axios.post(`${apiUrl}users/authenticate`, JSON.stringify({ username, password}))
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

function register(user) {
    return await axios.post(`${apiUrl}/users/register`, JSON.stringify(user)).then(handleResponse)
}

function getAll() {
    return await axios.get(`${apiUrl}/users`).then(handleResponse)
}


function getById(id) {
    return await axios.get(`${apiUrl}/users/${id}`).then(handleResponse)
}

function update(user) {
    return await axios.put(`${apiUrl}/users/${user.id}`, JSON.stringify(user)).then(handleResponse)
}

// prefixed function name with underscore because delete is a reserved word in javascript
function _delete(id) {
    return await axios.delete(`${apiUrl}/users/${id}`).then(handleResponse)
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