import { userService } from '../../services'
import { router } from '../../router'

const user = JSON.parse(localStorage.getItem('user'))
const state = user
    ? { status: { loggedIn: true }, user }
    : { status: {}, user: null }

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
        state.status = { loggedIn: true }
        state.user = user
    },
    loginFailure(state) {
        state.user = null
    },
    logout(state) {
        state.status = {}
        state.user = null
    },
    register(state) {
        state.status = {}
        state.user = null
    }
}

const getters = {
    user: (state) => {
        return state.user.data
    }
}

export const account = {
    namespaced: true,
    state,
    actions,
    mutations,
    getters
}