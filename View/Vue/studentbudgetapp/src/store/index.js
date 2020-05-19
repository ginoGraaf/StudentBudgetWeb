import Vue from 'vue'
import Vuex from 'vuex'

import { account } from './modules/account'
import { users } from './modules/users'
import { expenses } from './modules/expenses'

Vue.use(Vuex)

export const store = new Vuex.Store({
    modules: {
        account,
        users,
        expenses
    }
})
