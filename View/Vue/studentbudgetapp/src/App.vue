<template>
  <div id="app">
    
    <pie :pieData="pieData"/>
  </div>
</template>

<script>
//import HelloWorld from './components/HelloWorld.vue'
import Pie from './components/Pie'
export default {
  name: 'App',
  data:()=>
  {
    return{
      pieData:[{color:'#0B6487',value:10},
      {color:'#9D1F37',value:40},
      {color:'#F6931C',value:30},
      {color:'#9A6487',value:10},
      {color:'#58A384',value:10}]
    };
  },
components:
  {
    Pie
  }
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
