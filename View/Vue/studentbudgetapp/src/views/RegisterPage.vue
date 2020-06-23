<template>
    <div class='container col-2'>
        <h2>Register</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="Name">Name</label>
                <input type="text" v-model="user.Name" name="Name" class="form-control" />
            </div>
            <div class="form-group">
                <label for="Email">Email</label>
                <input type="text" v-model="user.Email" name="Email" class="form-control" />
            </div>
            <div class="form-group">
                <label htmlFor="Password">Password</label>
                <input type="password" v-model="user.Password" name="Password" class="form-control" />
            </div>
            <div class="form-group">
                <button class="btn btn-primary">Register</button>
                <router-link to="/login" class="btn btn-link">Cancel</router-link>
            </div>
        </form>
    </div>
</template>

<script>
import { mapState, mapActions } from 'vuex'

export default {
    data () {
        return {
            user: {
                Name: '',
                Email: '',
                Password: ''
            },
        }
    },
    computed: {
        ...mapState('account', ['status'])
    },
    methods: {
        ...mapActions('account', ['register']),
        handleSubmit() {
            this.register(this.user);
        }
    }
};
</script>