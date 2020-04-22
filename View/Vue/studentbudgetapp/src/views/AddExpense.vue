<template>
  <div class="AddExpense">
    <div>
      <input type="text" placeholder="Name" v-bind="Name">
    </div>
    <div>
      <input type="number" step="0.01" placeholder="0,00" v-bind="amount">
    </div>
    <div>
      <StandardExpense />
    </div>
    <div>
      <ChooseCategory />
    </div>
    <div>
      <input type="submit" value="Add expense!">
    </div>
  </div>
</template>

<script> 
import ChooseCategory from '../components/ChooseCategory.vue';
import StandardExpense from '../components/StandardExpense.vue';

export default {
  name: 'AddExpense',
  components: {
    ChooseCategory,
    StandardExpense
  }
}
</script>