import Student from "./Student.js";
import StudentDataManagement from "./StudentDataManagement.js";

export default class Evaluation {
    constructor(successGrade) {
        this.students = []
        this.succesGrade = successGrade
    }

    async addDefaultStudents(file) {
        (await StudentDataManagement.readAll(file)).forEach(student => {
            const fullname = student.fullname.split(' ')
            this.addStudent(fullname[0], fullname[1], student.grade)
        });
    }

    isDuplicate(lastName, firstName) {
        this.students.forEach(student => {
            if (student.lastName == lastName && student.firstName == firstName) {
                return true
            }
        });
    }

    isValid(lastName, firstName, grade) {
        return (!isNaN(+grade) && grade >= 0 && grade <= 20 && lastName != null && firstName != null)
    }

    addStudent(lastName, firstName, grade) {
        if (this.isDuplicate(lastName, firstName)) {
            return
        }  

        if (this.isValid(lastName, firstName, grade)){
            this.students.push(new Student(lastName, firstName, +grade))
        }     
    }

    calcMean() {
        let mean = 0
        this.students.forEach(student => {
            mean += student.grade
        });
        return (mean / this.students.length).toFixed(2)
    }

    calcNumberBestStudents() {
        const mean = this.calcMean()
        return this.students.filter((student) =>  student.grade > mean).length
    }
}