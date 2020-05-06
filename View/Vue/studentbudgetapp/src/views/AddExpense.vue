<template>
  <div class="AddExpense">
    <div>
      <input type="text" placeholder="Name" v-bind="Name">
    </div>
    <div>
      <input type="number" step="0.01" placeholder="0,00" v-bind="amount">
    </div>
    <div>
      <select>
        <option value="Daily">Once</option>
        <option value="Daily">Daily</option>
        <option value="Weekly">Weekly</option>
        <option value="Monthly">Monthly</option>
        <option value="Yearly">Yearly</option>
      </select>
    </div>
    <div>
      <ChooseCategory />
    </div>
  </div>
</template>

<script> 
//import ChooseCategory form '../components/ChooseCategory.vue'

export default {
  name: 'AddExpense'
}
</script>