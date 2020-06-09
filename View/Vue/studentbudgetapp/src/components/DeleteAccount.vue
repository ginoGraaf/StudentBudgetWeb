<template>
    <div>
    </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex'
import { router } from '../router/'
export default {
    name: 'DeleteAccount',
    methods: mapActions('users', ['deleteAccount']),
    computed: mapGetters('account', ['user']),
    created() {
        this.deleteAccount(this.user.id)
        router.push('/login')
    }
}
</script>

<style scoped>
</style>