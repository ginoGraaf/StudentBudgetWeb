<template>
    <div>
      <input type="checkbox" v-bind="Weekly"><span>Weekly</span>
      <input type="checkbox" v-bind="Monthly"><span>Monthly</span>
      <input type="checkbox" v-bind="Annual"><span>Annual</span>
    </div>
</template>

<script>
export default {
    name: 'StandardExpense'
}
</script>

<style scoped>

</style>