export default class StudentDataManagement {
    static async readAll(file) {
        return await (await fetch(file)).json()
    }
}