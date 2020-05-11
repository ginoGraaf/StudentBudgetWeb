<template>
  <div id="app">
    <div>
    <userInfo></userInfo>
    </div>
    <div>
    <PieComponent v-bind="piedata" ></PieComponent>
   </div>
  </div>
</template>

<script>
import PieComponent from './components/PieComponent'
import userInfo from'./components/UserInformation'
export default {
  name: 'App',
  components:{
    PieComponent,
    userInfo,
  },

}

</script>

<style lang="css">
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
body{
  front-size: 1rem;
  front-family:tahoma;
  background-color: #333;
  color: #fefefe;
}

#app {
position: relative;
display: flex;
justify-content: center;
align-items: flex-start;
min-height: 100vh;
width: 100%;
padding: 20px;
}
</style>
