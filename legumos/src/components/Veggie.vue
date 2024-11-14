<script setup>
const {veggie} = defineProps(['veggie'])
</script>
<template>
    <div class="bob">
        <p>{{ veggie.Name }} {{ veggie.Variety }}</p>
        <p>({{ veggie.SaleWeight }}Kgs)</p>
        <p>{{ veggie.SaleDate }}</p>
    </div>
    
</template>
<style scoped>
    .bob{
        display: flex;
        align-items: center;
        flex-direction: column;       
        background-color: var(--green-head);
        color:var(--text-white);
        min-width: 10rem;
        width: 30%;
        
    }
    p{
        margin:0;
        font-size: 3rem;
    }
</style>