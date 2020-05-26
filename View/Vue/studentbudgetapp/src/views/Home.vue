<template>
  <div class="home">
    <div class="grid-container">
      <div>
        <OverViewHeader />
        <ExpenseOverview/>
      </div>
      <div>
        <ExpensesHeader />
        <userInfo></userInfo>
        <PieComponent v-bind="piedata" />
      </div>
      <div>
        <Header />
          <AddCategory v-on:add-category="createCategory" />
          <Categories v-bind:categories="categories" v-on:del-category="deleteCategory" />
      </div>
    </div>
  </div>
</template>


<script src="https://unpkg.com/axios/dist/axios.min.js"></script>
<script>

import userInfo from'../components/UserInformation'
import PieComponent from '../components/PieComponent'
import Header from '../components/Header';
import OverViewHeader from '../components/OverViewHeader';
import ExpensesHeader from '../components/ExpensesHeader';
import ExpenseOverview from '../components/ExpenseOverview';
import Categories from '../components/Categories';
import AddCategory from '../components/AddCategory';
import Vue from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'


export default {
  name: 'Home',
  components: {
    Header,
    OverViewHeader,
    ExpenseOverview,
    ExpensesHeader,
    Categories,
    AddCategory,
    PieComponent,
    userInfo
  },
  mounted: function () {

    axios.get('https://localhost:44342/api/Category')
      .then(response => console.log(response))
      .catch(error => {
        if (!error.response) {
            // network error
            this.errorStatus = 'Error: Network Error';
        } else {
            this.errorStatus = error.response.data.message;
        }
      })
  },
  data() {
    return {
      categories: null,
    }
  },
  methods: {
    deleteCategory(id) {
      this.categories = this.categories.filter(category => category.id !== id);
    },
    addCategory(newCategory) {
      this.categories = [...this.categories, newCategory];
    },
    createCategory(newCategory) {
      const url = 'https://localhost:44342/api/Categories/${category.id}';
      return axios.put(url, newCategory);
    }
  }
}
</script>

<style scoped>
.grid-container {
  display: grid;
  grid-template-columns: auto auto auto;
  grid-gap: 10px;
  padding: 10px;
}

.grid-container > div {
  border: 1px solid black;
  text-align: center;
  font-size: 30px;
  height: 600px;
}
</style>