<template>
    <div id="Expenses" class='container-fluid'>  
        <table class='table align-self-center'>
            <thead>
                <tr>
                    <th scope='col'>Expense</th>
                    <th scope='col'>Amount</th>
                    <th scope='col'>Category</th>
                    <th scope='col'>Regulation</th>
                    <th scope='col'>Date</th>
                    <th scope='col'>Delete expense</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="expense in allExpenses" :key="expense.id">
                    <td>{{ expense.name }}</td>
                    <td>&euro;{{ expense.amount }}</td>
                    <td>{{ expense.category }}</td>
                    <td>{{ expense.regulation }}</td>
                    <td>{{ expense.date }}</td>
                    <td><button @click="deleteExpense(expense.id)" class="del">X</button></td>
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
        ...mapGetters('expenses', ['allExpenses']),
        ...mapGetters('account', ['user'])
    },
    methods: {
        ...mapActions('expenses', ['getAll', 'deleteExpense'])
    },
    created() {
        this.getAll(this.user.id)
    }
}
</script>

<style scoped>
.del {
    background: #ff0000;
    color: #fff;
    border: none;
    padding: 0px 9px;
    border-radius: 50%;
    cursor: pointer;
    float: right;
}
</style>