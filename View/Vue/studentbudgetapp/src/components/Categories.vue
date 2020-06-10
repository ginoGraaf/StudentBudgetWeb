<template>
    <div>
        <div v-bind:key="category.id" v-for="category in categories">
            <CategoryItem v-bind:category="category" v-on:del-category="$emit('del-category', category.id)" />
        </div>
    </div>
</template>

<script>
import CategoryItem from './CategoryItem.vue';

export default {
    name: "Categories",
    components: {
        CategoryItem
    },
    props: ["categories"]
}
</script>

<style scoped>

</style>