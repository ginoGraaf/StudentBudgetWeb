<template>
    <div id="Expenses"> 
        <li v-for="Expense in Expenses" :key="Expense.id">
           Expense: {{expense.name}} | Amount: {{expense.amount}}
        </li>
    </div>
</template>

<script>
import axios from "axios";
export default {
    name: ExpenseOverview,
    
    data(){
        return{
           Expenses:[] 
        }       
    },
    Methods: {

        async created(){   
            try{
               const res = await axios.get("URL");
            this.Expenses = res.data; 
            }
            catch(e){
                console.error(e);
            }
        }
    }



}
</script>

<style scoped>

</style>