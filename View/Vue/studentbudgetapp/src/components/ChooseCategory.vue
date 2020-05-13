<template>
    <div>
        <select v-model="selected" v-on:change="emitCategory">
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
            console.log('emitCategory', this.selected)
            this.$emit('chosen-category', this.selected)
        }
    }
}
</script>

<style scoped>

</style>