<template>
    <div class="collectorbody">
        <h2>username</h2>
        <h2>Balance</h2> 
        <div class="progress">
          <progress max="100" value="70"></progress>
        </div>
    </div>
</template>

<script>
export default {
    Name: "UserInformation",
}
</script>

<style scoped>
.collectorbody
{
        width: 300px;
        height: 180px;
        border:  2px solid #fefefe;
}
progress[value]
{
    -webkit-appearance: none;
    appearance: none;
    width: 250px;
    height: 20px;

}
progress[value]::-webkit-progress-bar
{
    background-color: #eee;
    border-radius: 2px;
    box-shadow: 0 2px 5px rgba(0, 0, 0, 0.25) inset;
}

progress[value]::-webkit-progress-value {
  background-image:-webkit-linear-gradient(-45deg, transparent 0%, rgba(0, 0, 0, .1) 0%, rgba(0,0, 0, .1) 0%, transparent 0%),-webkit-linear-gradient(top, rgba(255, 255, 255, .25),  rgba(0, 0, 0, .25)),-webkit-linear-gradient(left, rgb(10, 197, 110), rgb(5, 131, 72));

    border-radius: 2px; 

}


</style>