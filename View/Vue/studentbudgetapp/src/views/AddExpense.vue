<template>
  <div class="AddExpense">
    <form @submit="addExpense" @submit.prevent>
      <div>
        <input type="text" placeholder="Name" v-model="name">
      </div>
      <div>
        <input type="number" step="0.01" placeholder="0.00" v-model="amount">
      </div>
      <div>
        <RegularExpense v-model="regularExpense" v-on:regular-expense="setRegular"/>
      </div>
      <div>
        <ChooseCategory v-model="category" v-on:chosen-category="setCategory"/>
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

import axios from 'axios';
import { mapGetters } from 'vuex'


export default {
  name: 'AddExpense',
  components: {
    ChooseCategory,
    RegularExpense
  },
  computed: mapGetters('account', ['user']),
  data(){
    return{
      name: '',
      amount: '0.00',
      regularExpense: null,
      category: null
    }
  },
  methods: {
    setRegular(regulation) {
      console.log('setRegular' + regulation);
      
      this.regularExpense = regulation;
    },
    setCategory(chosenCategory) {
      console.log('setCategory', chosenCategory);

      this.category = chosenCategory;
    },
    addExpense() {
        console.log('addExpense' + this.regularExpense);

        const newExpense = {
            name: this.name,
            amount: this.amount,
            regularExpense: this.regularExpense,
            category: this.category,
            user: this.user,
        }
        console.log('user = ' + this.user)
        axios.post('/localhost/api/Expense/', newExpense)
        .then()
        .catch(error => console.log(error));
        this.$router.push('/');
    }

  }
}
</script>