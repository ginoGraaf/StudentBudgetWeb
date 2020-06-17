<template>
    <div>
        <form @submit="addCategory()">
            <input type="text" v-model="title" name="title" placeholder="Add Category...">
            <input type="submit" value="Submit" class="btn">
        </form>
    </div>
</template>

<script>
export default {
    name: "AddCategory",
    data() {
        return{
            title: ''
        }
    },
    methods: {
    addCategory() {
        const newCategory = {
            title: this.title
        }
        this.$emit('add-category', newCategory);

        this.title='';
    }
  }
}
</script>

<style scoped>
form {
    display: flex;
}

input[type="text"] {
    flex: 10;
    padding: 5px;
}

input[type="submit"] {
    flex: 2;
}
</style>