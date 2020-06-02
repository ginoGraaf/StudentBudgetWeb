<template>
    <div class="pie-chart" :style=pieStyle></div>
</template>

<script>
export default {
    props:
    [
        'pieData'
    ],
    computed:{
        pieStyle()
        {
            let sum=0;
            let style=this.pieData.map(
                piePart=> `${piePart.color} 0 ${sum+=piePart.value}%`
            );
            return {background: 'conic-gradient('+style.join(",")+')'};
        }
    }
}
</script>

<style lang="scss" scoped>

.pie-chart{
    width: 300px;
    height: 300px;
    border-radius: 50%;
    border:  2px solid #fefefe;
    border: 1px solid black;
    margin: auto;
}
</style>