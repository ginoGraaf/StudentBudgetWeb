<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/AddExpense">AddExpense</router-link>
    </div>
    <router-view/>
    <Header />
      <AddCategory v-on:add-category="addCategory" />
      <Categories v-bind:categories="categories" v-on:del-category="deleteCategory" />
  </div>
</template>

<script src="https://unpkg.com/axios/dist/axios.min.js"></script>
<script>
import Header from './components/Header';
import Categories from './components/Categories';
import AddCategory from './components/AddCategory';

export default {
  name: 'App',
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

<style>
*{
  box-sizing: border-box; 
  margin: 0;
  padding: 0;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}

body {
  font-family: Arial, Helvetica, sans-serif;
  line-height: 1.4;
}

.btn{
  display: inline-block;
  border: none;
  background: #555;
  color: #fff;
  padding: 7px 20px;
  cursor: pointer;
}

</style>
