<script setup>
import { onMounted, reactive, ref } from 'vue'

const data = ref(null);
async function fetchData() {
  const res = await fetch(
    `https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json`
  )
  data.value = await res.json()

}
</script>
<template>
    <h1>Ajouter un nouveau légume</h1>
    <form action="./NewVeggie.vue" method="get">
        <label for="name">Nom:</label>
        <input type="text" id="name" required placeholder="Babane">
        <label for="variete">Variété:</label>
        <input type="text" id="variete" required placeholder="Cavendish">
        <label for="couleur">Couleur:</label>
        <input type="text" id="couleur" required placeholder="Blouge">
        <label for="lifetime">Durée de vie:</label>
        <input type="number" id="lifetime" required placeholder=10>
        <label for="fresh">Frais?</label>
        <input type="checkbox" id="fresh">
        <label for="prix">Prix:</label>
        <input type="number" id="prix" required placeholder="50">
    </form>
</template>

<style scoped>
  label{
    margin-right:0.5rem;
  }
  input{
    margin-right:0.5rem;
  }
</style>