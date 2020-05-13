<template>
    <div id="Expenses" class='container'>  
        <table class='table col-4-sm align-self-center'>
            <thead>
                <tr>
                    <th scope='col'>Expense</th>
                    <th scope='col'>Amount</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="expense in allExpenses" :key="expense.id">
                    <td>{{ expense.name }}</td>
                    <td>{{ expense.amount }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
import { mapGetters, mapActions } from 'vuex'
export default {
    name: "ExpenseOverview",
    computed: {
        ...mapGetters('expenses', ['allExpenses'])
    },
    methods: {
        ...mapActions('expenses', ['getAll'])
    },
    created() {
        this.getAll()
    }
}
</script>

<style scoped>

</style>