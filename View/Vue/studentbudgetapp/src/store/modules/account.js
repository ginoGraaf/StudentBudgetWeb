import { userService } from '../../services'
import { router } from '../../router'

const user = JSON.parse(localStorage.getItem('user'))
const state = user
    ? { status: { loginText: "Logout", loggedIn: true }, user, wrong_login: false }
    : { status: { loginText: "Login", loggedIn: false }, user: null, wrong_login: false }

const actions = {
    login({ commit }, { username, password }) {
        userService.login(username, password)
            .then(
                user => {
                    commit('loginSuccess', user)
                    router.push('/')
                },
                error => {
                    commit('loginFailure', error)
                }
            )
    },
    logout({ commit }) {
        userService.logout()
        commit('logout')
    },
    register({ commit }, user) {
        userService.register(user)
            .then(
                router.push('/login')
            ).then(commit('register'))
    }
}

const mutations = {
    loginSuccess(state, user) {
        state.status = { loginText: "Logout", loggedIn: true }
        state.user = user,
        state.wrong_login = false
    },
    loginFailure(state) {
        state.user = null,
        state.wrong_login = true
    },
    logout(state) {
        state.status = {loginText: "Login"}
        state.user = null,
        state.wrong_login = false
    },
    register(state) {
        state.status = {loginText: "Login"}
        state.user = null,
        state.wrong_login = false
    }
}

const getters = {
    user: (state) => {
        return state.user.data
    },
    loginText: (state) => {
        return state.status.loginText
    },
    loggedIn: (state) => {
        return state.status.loggedIn
    },
    wrong_login: (state) => (state.wrong_login)
}

export const account = {
    namespaced: true,
    state,
    actions,
    mutations,
    getters
}