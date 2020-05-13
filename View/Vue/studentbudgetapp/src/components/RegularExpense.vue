<template>
    <div>
      <input type="radio" class="radio" v-model="OneTime"  value="null" name="regularExpense" v-on:change="oneTimeExpense"><span>One time</span>
      <input type="radio" class="radio" v-model="Weekly" value="weekly" name="regularExpense" v-on:change="weeklyExpense"><span>Weekly</span>
      <input type="radio" class="radio" v-model="Monthly" value="monthly" name="regularExpense" v-on:change="monthlyExpense"><span>Monthly</span>
      <input type="radio" class="radio" v-model="Annual" value="annual" name="regularExpense" v-on:change="annualExpense"><span>Annual</span>
      </div>
</template>

<script>
export default {
  name: 'RegularExpense',
  data() {
    return{
      OneTime: null,
      Weekly: 'weekly',
      Monthly: 2,
      Annual: String('annual')
    }
  },
  methods: {
    oneTimeExpense(){
      this.$emit('regular-expense', null)
    },
    weeklyExpense(){
      this.$emit('regular-expense', this.Weekly)
    },
    monthlyExpense(){
      this.$emit('regular-expense', this.Monthly)
    },
    annualExpense(){
      this.$emit('regular-expense', this.Annual)
    }
  }
}

</script>

<style scoped>

</style>