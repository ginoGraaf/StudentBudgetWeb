<template>
  <div class="AddExpense">
    <form @submit="addExpense()" @submit.prevent>
      <div>
        <input type="text" placeholder="Name" v-model="name">
      </div>
      <div>
        <input type="number" step="0.01" placeholder="0,00" v-model="amount">
      </div>
      <div>
        <RegularExpense v-model="regularExpense" v-on:regular-expense="setRegular"/>
      </div>
      <div>
        <ChooseCategory v-model="category"/>
      </div>
      <div>
        <input type="submit" value="Add expense!" class="btn">
      </div>
    </form>
  </div>
</template>

<script> 
import ChooseCategory from '../components/ChooseCategory.vue';
import RegularExpense from '../components/RegularExpense.vue';

import { uuid } from 'vue-uuid';

export default {
  name: 'AddExpense',
  components: {
    ChooseCategory,
    RegularExpense
  },
  data(){
    return{
      name: '',
      amount: '0,00',
      regularExpense: null,
      category: null
    }
  },
  methods: {
    setRegular(regulation) {
      console.log('setRegular' + regulation);
      
      this.regularExpense = regulation;
    },
    addExpense() {
        console.log('addExpense' + this.regularExpense);

        const newExpense = {
            id: uuid.v4(),
            name: this.name,
            amount: this.amount,
            regularExpense: this.regularExpense,
            category: this.category
        }
        this.$emit('add-expense', newExpense);
    }

  }
}
</script>