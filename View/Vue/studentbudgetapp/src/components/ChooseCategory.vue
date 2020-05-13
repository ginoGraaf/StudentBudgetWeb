<template>
    <div>
        <select v-model="selected" v-on:change="emitCategorie">
            <option v-for="Category in Categories" :key="Category"> {{ Category.title }} </option>
        </select>
    </div>
</template>

<script>
export default {
    name: 'ChooseCategory',
    data() {
        return {
            selected: '',
            Categories: [
            {
                id: 0,
                title: "No category"
            },
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
    },
    methods: {
        emitCategory() {
            this.$emit('chosenCategory', this.selected)
        }
    }
}
</script>

<style scoped>

</style>