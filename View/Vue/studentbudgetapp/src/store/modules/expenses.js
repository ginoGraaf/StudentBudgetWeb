import { expenseService } from '../../services/'

const state = () => ({
    expenses: [],
    singleExpense: {}
})

const actions = {
    getAll({commit}) {
        commit('getAllCommit', expenseService.getAll())
    },
    getById({commit}, id) {
        commit('getByIdCommit', expenseService.getById(id))
    },
    deleteExpense({commit}, id) {
        expenseService.deleteById(id)
        this.getAll()
        commit('deleteExpense')
    }
}

const mutations = {
    getAllCommit(state, expenses) {
        expenses.then(resp => {state.expenses = resp})
    },
    getByIdCommit(state, expense) {
        expense.then(resp => {state.singleExpense = resp})
    },
    deleteExpense() {
        console.log('Expense deleted')
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