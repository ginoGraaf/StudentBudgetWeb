<template>
  <div class="AddExpense">
    <div>
      <input type="text" placeholder="Name" v-bind="Name">  
    </div>
    <div>
      <input type="number" step="0.01" placeholder="0,00" v-bind="amount"> 
    </div>
    <div>
      <RegularExpense/> 
    </div>
    <div>
      <ChooseCategory/> 
    </div>
    <div>
      <input type="submit" value="Add expense!">
    </div>
  </div>
</template>

<script> 
import ChooseCategory from '../components/ChooseCategory.vue';
import RegularExpense from '../components/RegularExpense.vue';

export default {
  name: 'AddExpense',
  components: {
    ChooseCategory,
    RegularExpense
  }
}
</script>

<style scoped>

</style>