<script>
export default {
    data() {
        return {
            name:"",
            grade:""
        }
    },
    methods: {
        clickEv() {
            this.$emit('submit', this.name, this.grade)
            this.name = ""
            this.grade=""
        }
    }
}
</script>
<template>
    <form action="">
        <h2>Ajouter une note</h2>
        <label>Nom Prenom: <input type="text" v-model="name"></label>
        <label>Note: <input type="text" v-model="grade"></label>
        <button type="button" @click="clickEv">Ajouter</button>
    </form>
</template>

<style scoped>
    form {
        color: var(--color-text)
    }
    
</style>