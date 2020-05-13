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
                <tr v-for="Expense in Expenses" :key="Expense.id">
                    <td>{{ Expense.name }}</td>
                    <td>{{ Expense.amount }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    name: "ExpenseOverview",
    
    data(){
        return {
           Expenses: [
                {
                    id: 1,
                    name: "Boodschappen",
                    amount: "18.34"
                },
                {
                    id: 2,
                    name: "Zorgverzekering",
                    amount: "99.50"
                },
                {
                    id: 3,
                    name: "Autoverzekering",
                    amount: "84.38"
                }
            ] 
        }       
    }
}
</script>

<style scoped>

</style>