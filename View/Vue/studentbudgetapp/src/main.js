import Vue from 'vue'
import Vuex from 'vuex'
import App from './App.vue'
import router from './router'

Vue.config.productionTip = false
Vue.Use(Vuex)

new Vue({
  store,
  router,
  render: h => h(App)
}).$mount('#app')
