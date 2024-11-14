<script setup>
import { onMounted, reactive, ref } from 'vue'
import getData from '@/fetchData.js'

const data = ref(null);
async function fetchData() {
  const res = await fetch(
    `https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json`
  )
  data.value = await res.json()

}

const sort = reactive({
  Name: true,
  Variety: false,
  PrimaryColor: false,
  LifeTime: false,
  Fresh: false
})

function trierString(criteria) {
  sort[criteria] = !sort[criteria]
  
  data.value.sort((l1, l2) => sort[criteria] ? l1[criteria].localeCompare(l2[criteria]) : l2[criteria].localeCompare(l1[criteria])) 
}

function trierNum(criteria) {
  sort[criteria] = !sort[criteria]
  
  data.value.sort((l1, l2) => sort[criteria] ? l1[criteria] - l2[criteria] : l2[criteria] - l1[criteria]) 
}

function deleteRow(event) {
  const tr = event.target.parentNode.parentNode.remove()
  
}
//onMounted(fetchData);
onMounted(async () => data.value = await getData("legumo", "https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json"))
// ne pas oublier de charger les données

</script>

<template>
    <main>
      <h1>Liste des légumes</h1>
      <table>
        <thead>
          <tr>
            <th @click="() => trierString('Name')">Nom</th>
            <th @click="() => trierString('Variety')">Variété</th>
            <th @click="() => trierString('PrimaryColor')">Couleur</th>
            <th @click="() => trierNum('LifeTime')">Durée Conservation</th>
            <th @click="() => trierNum('Fresh')">Frais</th>
            <th>Action</th>
          </tr>
        </thead>
        <tr v-for="item of data">
          <td>{{ item.Name }}</td>
          <td>{{ item.Variety }}</td>
          <td>{{ item.PrimaryColor }}</td>
          <td>{{ item.LifeTime }}</td>
          <td>{{ item.Fresh==1 ? "Oui" : "Non" }}</td>
          <td><button>Editer</button> <button @click="deleteRow">Supprimer</button></td>
        </tr>
      </table>
    </main>
</template>

<style scoped>
th{
  background-color: var(--green-head);
  padding-right: 3rem;
  color: var(--thead-color);
  font-size: 2rem;
  
}
th:hover{
  cursor: pointer;
}

td{
  color: var(--tbody-color);
  font-size: 2rem;
}
button{
  font-size: 2rem;
}
</style>