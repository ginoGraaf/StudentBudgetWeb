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
    register(userToRegister) {
        userService.register(userToRegister)
            .then(
                user => {
                    router.push('/login')
                    return user
                }
            )
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
    }
}

export const account = {
    namespaced: true,
    state,
    actions,
    mutations,
}