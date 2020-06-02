<template>
  <div class="home container-fluid">
    <div class="row justify-content-between">
      <div class="col-sm-4 text-center">
        <div class="item">
          <OverViewHeader />
          <ExpenseOverview/>
        </div>
      </div>
      <div class="col-sm-4 text-center">
        <div class="item">
          <ExpensesHeader />
          <userInfo></userInfo>
          <PieComponent v-bind="piedata" />
        </div>
      </div>
      <div class="col-sm-4 text-center">
        <div class="item">
          <Header />
          <AddCategory v-on:add-category="createCategory" />
          <Categories v-bind:categories="categories" v-on:del-category="deleteCategory" />
        </div>
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
    axios.get('/localhost/api/Category')
      .then(response => this.categories = response.data)
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
      axios.delete('/localhost/api/Category/' + id)
      .then(response => {
        const categoryIndex = this.categories = this.categories.filter(category => category.id !== id)
      })
    },
    createCategory(newCategory) {
      if(newCategory.title != "") {
        let TestForURL={Id:0,Title:newCategory.title,Bedrag:0};
        const url = '/localhost/api/Category';
        axios.post(url, TestForURL, {headers:{'Content-Type': 'application/json'}});
      }
      else{
        alert("missing title!");
      }
    }
  }
}
</script>

<style scoped>
.container {
  display: grid;
  grid-gap: 10px;
  padding: 10px;
}

.item {
  border: 1px solid black;
  text-align: center;
  font-size: 30px;
  padding: 0px;
  height: 600px;
}
</style>