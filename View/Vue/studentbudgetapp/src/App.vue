<template>
  <div id="app">
    <Header />
      <Categories v-bind:categories="categories" v-on:del-category="deleteCategory" />
  </div>
</template>

<script>
import Header from './components/Header';
import Categories from './components/Categories';

export default {
  name: 'App',
  components: {
    Header,
    Categories
  },
  data() {
    return{
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
    }
  }
}
</script>

<style>
*{
  box-sizing: border-box; 
  margin: 0;
  padding: 0;
}

body{
  font-family: Arial, Helvetica, sans-serif;
  line-height: 1.4;
}

</style>
