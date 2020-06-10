<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/viewExpenses">View Expenses</router-link> | 
      <router-link to="/AddExpense">AddExpense</router-link> | 
      <router-link to="/YourSavingGoal">Set Saving Goal</router-link> |
      <router-link to="/login">{{ loginText }}</router-link> | 
      <router-link v-if="loggedIn" to="/deleteAccount">Delete Account</router-link>
      <router-link v-else to="/register">Register</router-link>
    </div>
    <router-view />
  </div>
</template>

<script>
import { mapGetters } from 'vuex'
export default {
  name: 'App',
  computed: mapGetters('account', ['loginText', 'loggedIn'])
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
