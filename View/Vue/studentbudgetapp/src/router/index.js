import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import LoginPage from '../views/LoginPage.vue'
import RegisterPage from '../views/RegisterPage.vue'
import AddExpense from '../views/AddExpense.vue'
import ExpenseOverview from '../views/ExpenseOverview'

Vue.use(VueRouter)

const routes = [
  { path: '/', name: 'Home', component: Home },
  { path: '/login', name: 'Login', component: LoginPage},
  { path: '/register', name: 'Register', RegisterPage },
  { path: '/AddExpense', name: 'AddExpense', component: AddExpense },
  { path: '/ExpenseOverview', name: 'ExpenseOverview', component: ExpenseOverview }
];

export const router = new VueRouter({
  routes
})

router.beforeEach((to, from, next) => {
  // redirect to login page if not logged in and trying to access a restricted page
  const publicPages = ['/login', '/register']
  const authRequired = !publicPages.includes(to.path)
  const loggedIn = localStorage.getItem('user')

  if (authRequired && !loggedIn) {
    //return next('/login')
    next()
  } else {
    next()
  }
}) 

