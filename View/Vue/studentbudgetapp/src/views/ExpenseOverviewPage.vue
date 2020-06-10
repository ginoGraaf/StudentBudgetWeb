<template>
    <div id="Expenses" class='container-fluid'>  
        <table class='table align-self-center'>
            <thead>
                <tr>
                    <th scope='col'>Expense</th>
                    <th scope='col'>Amount</th>
                    <th scope='col'>Category</th>
                    <th scope='col'>Regulation</th>
                    <th scope='col'>Delete expense</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="expense in allExpenses" :key="expense.id">
                    <td>{{ expense.name }}</td>
                    <td>&euro;{{ expense.amount }}</td>
                    <td>{{ expense.category }}</td>
                    <td>{{ expense.regulation }}</td>
                    <td>{{ expense.regulation }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
import { mapGetters, mapActions } from 'vuex'
export default {
    name: 'ExpenseOverviewPage',
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