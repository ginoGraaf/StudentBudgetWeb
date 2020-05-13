<template>
  <div class="home">
    <div class="grid-container">
  <div>
    <OverViewHeader />
    <!-- Overview component to be added -->
  </div>
  <div>
    <ExpensesHeader />
    <userInfo></userInfo>
    <PieComponent v-bind="piedata" />
  </div>
  <div>
    <Header />
      <AddCategory v-on:add-category="addCategory" />
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
import Categories from '../components/Categories';
import AddCategory from '../components/AddCategory';
import { GridPlugin, Page } from "@syncfusion/ej2-vue-grids";


export default {
  name: 'Home',
  components: {
    Header,
    OverViewHeader,
    ExpensesHeader,
    Categories,
    AddCategory,
    PieComponent,
    userInfo
  },
  data() {
    return {
      categories: [
        {
          id: 1,
          title: "Category one",
          bedrag: "€1.10"
        },
        {
          id: 2,
          title: "Category two",
          bedrag: "€1.10"
        }
      ]
      
    }
  },
  methods: {
    deleteCategory(id) {
      this.categories = this.categories.filter(category => category.id !== id);
    },
    addCategory(newCategory) {
      this.categories = [...this.categories, newCategory];
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