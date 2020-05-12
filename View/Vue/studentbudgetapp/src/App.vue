<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/AddExpense">AddExpense</router-link>
    </div>
    <router-view/>
    <div>
    <!--<userInfo></userInfo>-->
    </div>
  </div>
</template>

<script src="https://unpkg.com/axios/dist/axios.min.js"></script>
<script>

import userInfo from'./components/UserInformation'
export default {
  name: 'App',
  components:{
    
  },

}

</script>

<style lang="css">
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

#app {
position: relative;
display: flex;
justify-content: center;
align-items: flex-start;
height: 100vh;
width: 100%;
padding: 20px;
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
  font-size: 1rem;
  font-family:tahoma;
  color: #fefefe;
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
