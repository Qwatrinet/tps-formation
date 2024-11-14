<script>
import Evaluation from "@/classes/Evaluation.js"
import TableVue from "@/components/TableVue.vue"
import StatsVue from "@/components/StatsVue.vue"
import AddStudent from "@/components/AddStudent.vue"

export default {
    data() {
        return {
            eval: new Evaluation(12),
        }
    },
    components: {
        TableVue, StatsVue, AddStudent
    },
    async mounted() {
        this.eval.addDefaultStudents("/assets/eval.json")
    },
    methods: {
        addStudent(name, grade) {
            name = name.split(' ')
            this.eval.addStudent(name[0], name[1], grade)
        }
    }


}


</script>
<template>
    <AddStudent @submit="addStudent"></AddStudent>
    <h1>Résultat de l'évaluation</h1>
    <TableVue :students="eval.students" :grad="eval.succesGrade" />
    <StatsVue :eval="eval"></StatsVue>
</template>
