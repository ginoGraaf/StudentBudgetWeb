<template>
    <div>

      <input type="radio" class="radio" v-model="regulation" value="null" name="regularExpense" v-on:change="setRegulation"><span>  One time  </span>
      <input type="radio" class="radio" v-model="regulation" value="weekly" name="regularExpense" v-on:change="setRegulation"><span>  Weekly  </span>
      <input type="radio" class="radio" v-model="regulation" value="monthly" name="regularExpense" v-on:change="setRegulation"><span>  Monthly  </span>
      <input type="radio" class="radio" v-model="regulation" value="annual" name="regularExpense" v-on:change="setRegulation"><span>  Annual  </span>
      <br>
      <br>
    </div>

</template>

<script>
export default {
  name: 'RegularExpense',
  data() {
    return{
      OneTime: null,
      Weekly: 'weekly',
      Monthly: 'monthly',
      Annual: 'annual',
      regulation: null
    }
  },
  methods: {
    setRegulation(){
      this.$emit('regular-expense', this.regulation)
    }
  }
}

</script>

<style scoped>
*{font-family: 'Roboto', sans-serif;}

@keyframes click-wave {
  0% {
    height: 40px;
    width: 40px;
    opacity: 0.35;
    position: relative;
  }
  100% {
    height: 200px;
    width: 200px;
    margin-left: -80px;
    margin-top: -80px;
    opacity: 0;
  }
}

.radio {
  -webkit-appearance: none;
  -moz-appearance: none;
  -ms-appearance: none;
  -o-appearance: none;
  appearance: none;
  position: relative;
  top: 13.33333px;
  right: 0;
  bottom: 0;
  left: 0;
  height: 40px;
  width: 40px;
  transition: all 0.15s ease-out 0s;
  background: #cbd1d8;
  border: none;
  color: #fff;
  cursor: pointer;
  display: inline-block;
  margin-right: 0.5rem;
  outline: none;
  position: relative;
  z-index: 1000;
}
.radio:hover {
  background: #9faab7;
}
.radio:checked {
  background: #40e0d0;
}
.radio:checked::before {
  height: 40px;
  width: 40px;
  position: absolute;
  content: '✔';
  display: inline-block;
  font-size: 26.66667px;
  text-align: center;
  line-height: 40px;
}
.radio:checked::after {
  -webkit-animation: click-wave 0.65s;
  -moz-animation: click-wave 0.65s;
  animation: click-wave 0.65s;
  background: #40e0d0;
  content: '';
  display: block;
  position: relative;
  z-index: 100;
}
.radio.radio {
  border-radius: 50%;
}
.radio::after {
  border-radius: 50%;
}

body {
  display: -webkit-flex;
  display: -moz-flex;
  display: -ms-flexbox;
  display: flex;
  background: #e8ebee;
}
</style>