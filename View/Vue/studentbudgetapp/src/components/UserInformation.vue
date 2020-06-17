<template>
    <div class="collectorbody">
        <h2>{{ user.name }}</h2>
        <h2>Balance</h2> 

    </div>
</template>

<script>
import { mapGetters } from 'vuex'
export default {
    Name: "UserInformation",
    computed: mapGetters('account', ['user'])
}
</script>

<style scoped>
.collectorbody
{
    width: 300px;
    height: 180px;
    border:  2px solid #fefefe;
    margin: auto;
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

</style>