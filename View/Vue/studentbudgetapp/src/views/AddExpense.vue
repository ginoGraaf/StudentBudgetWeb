<template>
  <div class="AddExpense">
    <div>
      <input type="text" placeholder="Name" v-bind="Name">
    </div>
    <div>
      <input type="number" step="0.01" placeholder="0,00" v-bind="amount">
    </div>
    <div>
      <input type="checkbox" v-bind="Weekly"><span>Weekly</span>
      <input type="checkbox" v-bind="Monthly"><span>Monthly</span>
      <input type="checkbox" v-bind="Annual"><span>Annual</span>
    </div>
    <div>
      <ChooseCategory v-bind:ChooseCategory="ChooseCategory"/>
    </div>
  </div>
</template>

<script> 
import ChooseCategory from '../components/ChooseCategory.vue';

export default {
  name: 'AddExpense'
}
</script>