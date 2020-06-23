<template>
    <div class='container col-2'>
        <h2>Login</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="username">Email address</label>
                <input type="text" v-model="username" name="username" class="form-control" :class="{ 'is-invalid': submitted && !username }" />
                <div v-show="submitted && !username" class="text-danger">Username is required</div>
            </div>
            <div class="form-group">
                <label htmlFor="password">Password</label>
                <input type="password" v-model="password" name="password" class="form-control" :class="{ 'is-invalid': submitted && !password }" />
                <div v-show="submitted && !password" class="text-danger">Password is required</div>
                <div v-if="wrong_login" class="text-danger">Email or password is wrong.</div>
            </div>
            <div class="form-group">
                <button class="btn btn-primary">Login</button>
                <router-link to="/register" class="btn btn-link">Register</router-link>
            </div>
        </form>
    </div>
</template>

<script>
import { mapGetters, mapState, mapActions } from 'vuex'

export default {
    data () {
        return {
            username: '',
            password: '',
            submitted: false,
        }
    },
    computed: {
        ...mapState('account', ['status']),
        ...mapGetters('account', ['wrong_login'])
    },
    methods: {
        ...mapActions('account', ['login', 'logout']),
        handleSubmit() {
            this.submitted = true;
            const { username, password } = this;
            if (username && password) {
                this.login({ username, password })
            }
        },
    },
    created() {
        this.logout()
    }
}
</script>