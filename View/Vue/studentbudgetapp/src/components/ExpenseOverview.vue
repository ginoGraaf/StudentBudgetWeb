<template>
    <div id="Expenses" class='container-fluid'>  
        <table class='table align-self-center'>
            <thead>
                <tr>
                    <th scope='col'>Expense</th>
                    <th scope='col'>Amount</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="expense in allExpenses" :key="expense.id">
                    <td>{{ expense.name }}</td>
                    <td>&euro;{{ expense.amount }}</td>
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
        ...mapGetters('expenses', ['allExpenses']),
        ...mapGetters('account', ['user'])
    },
    methods: {
        ...mapActions('expenses', ['getAll'])
    },
    created() {
        this.getAll(this.user.id)
    }
}
</script>

<style scoped>

</style>