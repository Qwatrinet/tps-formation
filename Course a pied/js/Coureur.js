export default class Coureur {
    constructor(nom, pays, temps) {
        this.fullNom = nom;
        this.pays = pays;
        this.temps = temps;
    }

    get nom() {
        return this.fullNom.split(" ")[0];
    }

    get prenom() {
        return this.fullNom.split(" ")[1];
    }

    get tempsFinal() {
        const sec = (this.temps % 60 < 10) ? "0" + this.temps % 60 : this.temps % 60
        return Math.floor(this.temps / 60) + "min" + sec + "s"
    }
}
