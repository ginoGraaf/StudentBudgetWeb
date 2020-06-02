<template>
<div>
  <form>
  <input v-model="EarningGoal" type="Text" placeholder="Place enter a savings target?">
  <input v-model="Money" type="number" step="0.01" max=”0″ placeholder="0">
  <button type="submit" @click="SendData">Set Goal</button>
  </form>
</div>
</template>>

<script>
import axios from 'axios'
export default {
   data()
   {
     return{
            EarningGoal:"",
            Money:0.00,
            Goal:{GoalName:"",ID:0,UserID:0,savingAmount:0}
           }
       },
        mounted: function () {

        axios.get('/localhost/api/SavingTarget/1').then(response => this.Goal = response.data)
        console.log(this.Goal);
      },
    methods:{
     
       SendData()
        {
              const url = '/localhost/api/SavingTarget';
              let SaveGoal={GoalName:this.EarningGoal,ID:1,UserID:1,savingAmount:this.Money.toString()};
          axios.post(url,SaveGoal,{headers:{'Content-Type': 'application/json'}});
            console.log(SaveGoal.GoalName+"  "+SaveGoal.savingGoal);
            console.log("test");
        }
    }
}
</script>

<style scoped>

</style>