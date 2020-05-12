<template>
  <div class="home">
    <div class="grid-container">
  <div>
    <!-- Gino overzicht component to be added -->
  </div>
  <div>
    <!-- Gino pie chart component to be added -->
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

import Header from '../components/Header';
import Categories from '../components/Categories';
import AddCategory from '../components/AddCategory';
import { GridPlugin, Page } from "@syncfusion/ej2-vue-grids";

export default {
  name: 'Home',
  components: {
    Header,
    Categories,
    AddCategory
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
  height: 300%;
}
</style>