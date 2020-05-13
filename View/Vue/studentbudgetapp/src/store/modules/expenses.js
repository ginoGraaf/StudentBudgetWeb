import { expenseService } from '../../services/'

const state = () => ({
    expenses: []
})

const actions = {
    getAll({commit}) {
        commit('getAllCommit', expenseService.getAll())
    }
}

const mutations = {
    getAllCommit(state, expenses) {
        state.expenses = expenses
    }
}

export const getters = {
    allExpenses: (state) => {
        return state.expenses
    }
}

export const expenses = {
    namespaced: true,
    state,
    getters,
    actions,
    mutations
}