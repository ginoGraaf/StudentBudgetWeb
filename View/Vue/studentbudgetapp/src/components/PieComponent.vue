<template>
<div>
   <pie :pieData="pieData"/>
</div>
</template>

<script>

import Pie from './Pie'
import axios from 'axios'

import { mapGetters } from 'vuex'
export default {
    components:{
        Pie,
        
    },
        props: ["categories"],
        computed: mapGetters('account', ['user']),
  data:()=>
  {
    return{
      data:[],
      pieData:[],
    };
  },
 mounted:function()
{
  axios.get('/localhost/api/Pie/'+this.user.id).then((response) => 
  {
    console.log(response.data); 
    this.data=response.data;

    var i=0;
    for (i=0; i<this.data.length;i++)
    {
      let convertData={color:"",value:0};
      convertData.color=this.data[i].color;
      convertData.value=this.data[i].precentage;
      this.pieData.push(convertData);
    }
  }).catch(error => 
  {
        if (!error.response) {
            // network error
            console.log("No Data was send to");
            this.errorStatus = 'Error: No Pie Data Was send';
        } else {
            this.errorStatus = error.response.data.message;
        }
      })
}

}
</script>