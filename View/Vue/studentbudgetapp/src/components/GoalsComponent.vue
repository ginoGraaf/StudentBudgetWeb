<template>
<div>
  <form>
  <input v-model="EarningGoal" type="Text" placeholder="Place enter a savings target?">
  <input v-model="Money" type="number" placeholder="0">
  <button type="submit" @click="SendData">Set Goal</button>
  </form>
</div>
</template>>

<script>
export default {
   data()
   {
     return{
            EarningGoal:"",
            Money:0
           }
       },
    methods:{
        SendData()
        {
            console.log(this.EarningGoal+"  "+this.Money);
            console.log("test");
        }
    }
}
</script>

<style scoped>

</style>