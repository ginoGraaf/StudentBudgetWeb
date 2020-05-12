<template>
<div>
   <pie :pieData="pieData"/>
</div>
</template>

<script>

import Pie from './Pie'

export default {
    components:{
        Pie
    },
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

}
</script>