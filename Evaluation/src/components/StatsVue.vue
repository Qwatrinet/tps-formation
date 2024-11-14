<script>
export default {
    props: ["eval"]
}
</script>

<template>
    <ul>
        <li>Nombre d'étudiants: {{ eval.students.length }}</li>
        <li>Moyenne de la classe: {{ eval.calcMean() }}</li>
        <li>Nombre d'étudiants au dessus de la moyenne: {{ eval.calcNumberBestStudents() }}</li>
        <li>Note Eliminatoire: {{ eval.succesGrade }}</li>
    </ul>
</template>

<style scoped>
li {
    color: var(--color-text)
}
</style>