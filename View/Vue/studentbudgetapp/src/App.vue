<template>
  <div id="app">
      <Categories v-bind:categories="categories"/>
  </div>
</template>

<script>
import Categories from './components/Categories';

export default {
  name: 'App',
  components: {
    Categories
  },
  data() {
    return{
      categories: [
        {
          id: 1,
          title: "Category one"
        },
        {
          id: 2,
          title: "Category two"
        }
      ]
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
