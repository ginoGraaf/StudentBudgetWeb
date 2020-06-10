import { userService } from '../../services'

const state = {
    all: {},
    singleUser: {}
}

const actions = {
    getAll({ commit }) {
        commit('getAllRequest')

        userService.getAll()
            .then(
                users => commit('getAllSuccess', users),
                error => commit('getAllFailure', error)
            )
    },

    getById({ commit }, id) {
        userService.getById(id)
            .then(
                users => commit('getById', users),
                error => commit('getByIdError', error)
            )
    },

    deleteAccount({ commit }, id) {
        userService.deleteAccount(id)
            .then(
                commit('deleteSuccess', id)
            )
    }
}

const mutations = {
    getAllRequest(state) {
        state.all = { loading: true }
    },
    getAllSuccess(state, users) {
        state.all = { items: users }
    },
    getAllFailure(state, error) {
        state.all = { error }
    },
    getById(state, user) {
        state.singleUser = user
    },
    getByIdError(state, error) {
        console.log(error)
    },
    deleteSuccess() {
        // Do nothing at all!
    }
}

export const users = {
    namespaced: true,
    state,
    actions,
    mutations
}