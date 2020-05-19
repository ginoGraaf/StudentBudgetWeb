<template>
  <div id="app">
    <div>
    <userInfo></userInfo>
    </div>
    <div>
    <PieComponent v-bind="piedata" ></PieComponent>
    <GoalsComponent></GoalsComponent>
   </div>
  </div>
</template>

<script>
import PieComponent from './components/PieComponent'
import userInfo from'./components/UserInformation'
import GoalsComponent from './components/GoalsComponent'
export default {
  name: 'App',
  components:{
    PieComponent,
    userInfo,
    GoalsComponent,
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
