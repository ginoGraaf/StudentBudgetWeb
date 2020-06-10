<template>
<div>
   <pie :pieData="pieData"/>
</div>
</template>

<script>

import Pie from './Pie'
import axios from 'axios'
export default {
    components:{
        Pie
    },
        props: ["categories"],
  data:()=>
  {
    return{
      pieData:[],
      Category:[]
    };
  },
 mounted:function()
{
  console.log(this.categories);
  axios.get('/localhost/api/Pie').then(Response=>this.pieData=Response.data).then(response => console.log(response)).catch(error => {
        if (!error.response) {
            // network error
            console.log("No Data was send to");
            this.errorStatus = 'Error: No Pie Data Was send';
        } else {
            this.errorStatus = error.response.data.message;
        }
      })
}




// {color:'#0B6487',value:10},
//       {color:'#9D1F37',value:40},
//       {color:'#F6931C',value:30},
//       {color:'#9A6487',value:10},
//       {color:'#58A384',value:10}

}
</script>