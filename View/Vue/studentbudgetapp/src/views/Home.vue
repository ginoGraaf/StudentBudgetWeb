<template>
  <div class="home">
    <Header />
      <AddCategory v-on:add-category="addCategory" />
      <Categories v-bind:categories="categories" v-on:del-category="deleteCategory" />
  </div>
</template>

<script src="https://unpkg.com/axios/dist/axios.min.js"></script>
<script>
import Header from '../components/Header';
import Categories from '../components/Categories';
import AddCategory from '../components/AddCategory';

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