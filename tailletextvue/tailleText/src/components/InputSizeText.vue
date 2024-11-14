<script>
export default {
    props: ["size", "max", "min"],
    emits: ['update:size'],
    methods: {
        changeEv(e) {
            if (e.target.value > this.max || e.target.value < this.min) {
                this.$emit('update:size', 16)

                return
            }

            this.$emit('update:size', e.target.value)
        }
    }

}
</script>
<template>

    <label>Saisie manuelle : <input type="number" :min="min" :max="max" @change="changeEv" :value="size"></label>
    <slot>texte par défaut qu'on voit pas ici si y'a qq chose dans le parent</slot>
</template>

<style scoped>
label {
    margin-left: 1rem;
}
</style>