<script setup>
import { RouterLink } from 'vue-router'
</script>  

<template> 
    <header>
      <img src="/legumos.jpg" alt="miam">
      <menu>
        <li><RouterLink to="/bob">Ventes </RouterLink></li>
        <li>Nouvelles ventes</li>
        <li><RouterLink to="/">Légumes</RouterLink></li>
        <li><RouterLink to="/NewVeggie">Nouveau Légume</RouterLink></li>
      </menu>
      
    </header>
</template>  

<style scoped>
    img{
        margin-bottom: 0;
        width:100vw;
    }
    menu{
        margin-top:0;
        padding-top:1rem;
        padding-bottom: 1rem;
        background-color: var(--green-head);
        display: flex;
        flex-direction:row; 
        justify-content: space-around;
        list-style: none;
        width:100vw;
    }
    li{
      margin-right:2rem;
      font-size: 2rem;
      color: var(--text-white);

    }
    a{
      color:var(--text-white);
      text-decoration: none;
      &.router-link-active {
        font-weight: bold;
      }
    }

</style>