<template>
    <div>
        <div v-for="category in categories">
            <h3>{{category.title}}</h3>
        </div>
    </div>
</template>

<script>
export default {
    name: "Categories",
    props: ["categories"]
}
</script>

<style scoped>

</style>