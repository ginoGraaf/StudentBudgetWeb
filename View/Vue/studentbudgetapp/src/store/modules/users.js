import { userService } from '../../services'

const state = {
    all: {}
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