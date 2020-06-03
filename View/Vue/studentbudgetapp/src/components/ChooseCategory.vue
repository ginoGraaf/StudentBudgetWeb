<template>
    <div>

        <select class="dropbtn" v-model="selected" v-on:change="emitCategory">
            <option class="dropbtn" v-for="Category in Categories" :key="Category"> {{ Category.title }}</option>

        </select>
        <br>
        <br>
    </div>
</template>

<script>
import axios from 'axios';

export default {
    name: 'ChooseCategory',
    data() {
        return {
            selected: 'No category',
            Categories: []
        }
    },
    methods: {
        emitCategory() {
            console.log('emitCategory', this.selected)
            this.$emit('chosen-category', this.selected)
        }
    },
    created() {
        axios.get('https://localhost:5001/api/Category/').then(res => this.Categories = res.data).catch(err => console.log(err));
    }
}
</script>

<style scoped>

/* Dropdown Button */
.dropbtn {
  background-color: #40e0d0;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
  border-radius: 4%;
  display: inline-block;
  border-radius: .25rem;

}

/* The container <div> - needed to position the dropdown content */
.dropdown {
  position: relative;
  display: inline-block;
}

/* Dropdown Content (Hidden by Default) */
.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

/* Links inside the dropdown */
.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

/* Change color of dropdown links on hover */
.dropdown-content a:hover {background-color: #ddd;}

/* Show the dropdown menu on hover */
.dropdown:hover .dropdown-content {display: block;}

/* Change the background color of the dropdown button when the dropdown content is shown */
.dropdown:hover .dropbtn {background-color: #40e0d0;}

</style>