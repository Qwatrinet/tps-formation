<script setup>
import { onMounted, reactive, ref, computed } from 'vue'
import Veggie from '@/components/Veggie.vue'
import getData from '@/fetchData.js'
const data = ref(null);
async function fetchData() {
  const res = await fetch(
    `https://arfp.github.io/tp/web/javascript2/11-grocery/legumos-sales.json`
  )
  data.value = await res.json()

}
//onMounted(fetchData)
onMounted(async () => data.value = await getData("sales", "https://arfp.github.io/tp/web/javascript2/11-grocery/legumos-sales.json"))
</script>

<template> 
    <main>
      <div><Veggie v-for="veggie of data" :veggie="veggie"></Veggie>
      <!-- affiche un légume --></div>
      
    </main>  
</template>  

<style scoped>
div{
  display: flex;
  flex-wrap: wrap;
  flex-direction: row;
  gap:1.5rem;
  justify-content: center;
}

</style>