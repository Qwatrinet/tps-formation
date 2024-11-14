<script setup>
import { onMounted, reactive } from 'vue'
import Header from './components/Header.vue'
import { RouterView } from 'vue-router'

onMounted(() => {

})
</script>


<template>
  <Header></Header>  
  <RouterView/>
</template>

<style scoped>

</style>
