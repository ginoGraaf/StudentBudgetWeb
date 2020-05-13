<template>
    <div>
        <select>
            <option v-for="Category in Categories" :key="Category" v-on:selected="$emit('çategory', Category.id)"> {{ Category.title }} </option>
        </select>
    </div>
</template>

<script>
export default {
    name: 'ChooseCategory',
    data() {
        return {
            Categories: [
            {
                id: 1,
                title: "Groceries"
            },
            {
                id: 2,
                title: "Going out"
            }
            ]
        }
    }
}
</script>

<style scoped>

</style>