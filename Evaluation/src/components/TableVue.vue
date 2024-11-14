<script>
export default {
    props: ["students","grad"],
    methods: {
        isPassed(grade) {
            return (grade>=this.grad? "Oui" : "Non")
        }
    },
    computed: {
        sortStudents() {
            let sortedStudents = this.students
            sortedStudents.sort((a, b) => b.grade - a.grade)
            return sortedStudents
        }
    }
}
</script>

<template>
    <table>
        <thead>
            <tr>
                <th>Nom</th>
                <th>Prénom</th>
                <th>Note</th>
                <th>Obtenu</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="student of sortStudents" :key="student.id">
                <td>{{ student.lastName }}</td>
                <td>{{ student.firstName }}</td>
                <td>{{ student.grade }}</td>
                <td>{{ isPassed(student.grade) }}</td>
            </tr>
        </tbody>
    </table>
</template>

<style scoped>
    table{
        color:var(--color-table);
        background-color: var(--bg-color-table);
        border-spacing: 0px;
        border-bottom:1px solid;
        border-right: 1px solid;
    }
    th,td{
        border-left:1px solid;
        border-top:1px solid;
        padding:0.5rem;
    }
</style>