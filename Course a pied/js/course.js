import Coureur from "./coureur.js";

const response = (await (await fetch("/course/coureur.json")).json());

function CreateTrCoureur(coureur) {
    const tr = document.createElement("tr")
    const tdPays = document.createElement("td")
    tdPays.textContent = coureur.pays
    tr.appendChild(tdPays)
    const tdNom = document.createElement("td")
    tdNom.textContent = coureur.nom
    tr.appendChild(tdNom)
    tr.insertCell().textContent = coureur.prenom
    tr.insertCell().textContent = coureur.tempsFinal
    tr.insertCell().textContent = "+" + calcEcartGagnant(coureur) + "s"
    return tr;
}

function calcEcartGagnant(coureur) {
    return (coureur.temps - response[0].temps)
}

function calcTempsMoyen() {
    let moy = 0
    response.forEach(coureur => {
        moy += coureur.temps
    });
    moy = moy / response.length
    moy = moy.toFixed(0)
    const sec = (moy % 60 < 10) ? "0" + moy % 60 : moy % 60
    return Math.floor(moy / 60) + "min" + sec + "s"
}
const paysRepres = [];
const affichage = []
const filtrePays = document.querySelector("#pays")

function afficherlabel() {
    response.sort((a, b) => a.temps - b.temps)
    response.forEach(element => {
        const coureur = new Coureur(element.nom, element.pays, element.temps)
        if (!paysRepres.includes(coureur.pays)) {
            paysRepres.push(coureur.pays)
            const div = document.createElement("div")
            const label = document.createElement("label")
            const checkbox = document.createElement("input")
            checkbox.type = "checkbox"
            checkbox.id = coureur.pays
            label.setAttribute("for", checkbox.id)
            label.textContent = coureur.pays
            div.appendChild(checkbox)
            div.appendChild(label)
            checkbox.addEventListener("click", async (e) => {
                if (checkbox.checked) {
                    affichage.push(checkbox.id)
                    viderTableau()
                    afficherDonnees()
                }
                else {
                    affichage.splice(affichage.indexOf(checkbox.id), 1)
                    viderTableau()
                    afficherDonnees()
                }
            })
            filtrePays.appendChild(div)

        }

    });
    document.querySelector("#participants").textContent = response.length + " participants"
    document.querySelector("#gagnant").textContent = response[0].nom
    document.querySelector("#temps").textContent = "Temps moyen: " + calcTempsMoyen()
}

function viderTableau() {
    document.querySelector("tbody").remove()
    document.querySelector("table").appendChild(document.createElement("tbody"))
}
function afficherDonnees() {
    response.sort((a, b) => a.temps - b.temps)
    response.forEach(element => {
        const coureur = new Coureur(element.nom, element.pays, element.temps)
        if (affichage.length == 0 || affichage.includes(coureur.pays)) {
            document.querySelector("tbody").appendChild(CreateTrCoureur(coureur))
        }

    });
}

afficherlabel()
afficherDonnees()