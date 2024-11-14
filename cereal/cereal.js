const response = await fetch("https://arfp.github.io/tp/web/javascript2/10-cereals/cereals.json");
let cereals = (await response.json()).data;
let active = [];

function affichercereale(cereal) {
    const tr = document.createElement("tr");
    for (const key in cereal) {

        const td = document.createElement("td");
        td.textContent = cereal[key];
        tr.appendChild(td);
    }
    const td = document.createElement("td");
    if (cereal.rating > 80) {
        td.textContent = "A";
        td.style.backgroundColor = "darkgreen";
    }
    else if (cereal.rating > 70) {
        td.textContent = "B";
        td.style.backgroundColor = "#009900CC";
    }
    else if (cereal.rating > 55) {
        td.textContent = "C";
        td.style.backgroundColor = "#CCCC00CC";
    }
    else if (cereal.rating > 35) {
        td.textContent = "D";
        td.style.backgroundColor = "#CC6600CC";
    }
    else {
        td.textContent = "E";
        td.style.backgroundColor = "#CC0000CC";
    }
    tr.appendChild(td);
    const suppr = document.createElement("td");
    suppr.textContent = "❌";
    suppr.addEventListener("click", function (e) {
        document.querySelector("tbody").removeChild(e.target.parentNode); //e.target, c'est suppr
        moyenne();
    }) //on retire donc le parent de suppr de tbody
    tr.appendChild(suppr)
    return (tr)
}

function affichagetotal(tab) {
    document.querySelector("table").removeChild(document.querySelector("tbody"));
    const tbody = document.createElement("tbody")
    document.querySelector("table").appendChild(tbody);
    tab.forEach(cereal => {
        let tr = affichercereale(cereal);
        document.querySelector("tbody").appendChild(tr);
    });
}

function affichertri() {
    document.querySelector("table").removeChild(document.querySelector("tbody"));
    const tbody = document.createElement("tbody")
    document.querySelector("table").appendChild(tbody);
    active.forEach(element => {
        document.querySelector("tbody").appendChild(element);
    });
}

affichagetotal(cereals)
moyenne()


function nutriclass(cereal) {
    if (cereal.rating > 80) {
        return ("A")
    }
    else if (cereal.rating > 70) {
        return ("B")
    }
    else if (cereal.rating > 55) {
        return ("C")
    }
    else if (cereal.rating > 35) {
        return ("D")
    }
    else {
        return ("E")
    }
}

function moyenne() {
    //si il y a déja une moyenne affichée (une moyenne n'a pas d'id), on la retire.
    if (document.querySelector("tbody>tr:last-child>td:first-child").textContent=="") {
        document.querySelector("tbody").removeChild(document.querySelector("tbody>tr:last-child"))
    }
    let sum = 0
    let moyenne = 0
    document.querySelectorAll("tbody>tr").forEach(element => {
        
        sum += 1
        moyenne += parseInt(element.querySelector("td:nth-child(3)").textContent);
    });
    moyenne = (parseFloat(moyenne) / parseFloat(sum)).toFixed()
    let tr = document.createElement("tr");
    tr.setAttribute("id", "moyenne")
    let td0 = document.createElement("td")
    let td1 = document.createElement("td")
    td1.textContent = sum + " éléments affichés"
    let td2 = document.createElement("td")
    td2.textContent = "Moyenne calories " + moyenne
    tr.appendChild(td0)
    tr.appendChild(td1)
    tr.appendChild(td2)
    document.querySelector("tbody").appendChild(tr)
}

function remplissage(nutriscore) {
    const letter = nutriscore.name.toUpperCase();
    cereals.forEach(cereal => {
        if (nutriclass(cereal) == letter) {
            const tr = affichercereale(cereal)
            active.push(tr);
        }
    })
}

function vider(nutriscore) {
    const letter = nutriscore.name.toUpperCase();
    for (let i = active.length - 1; i >= 0; i--) {
        const select = active[i]
        const td = select.querySelector("td:nth-child(12)")
        if (td.textContent === letter) {
            active.splice(i, 1); //supprime l'élément en position i
        }
    }
}

function categoriser(categorie, tab) {
    switch (+categorie) {
        case 1:
            return tab.filter((tr) => +tr.querySelector("td:nth-child(8)").textContent < 1)
        case 2:
            return tab.filter((tr) => +tr.querySelector("td:nth-child(5)").textContent < 50)
        case 3:
            return tab.filter((tr) => +tr.querySelector("td:nth-child(10)").textContent >= 1 && +tr.querySelector("td:nth-child(6)").textContent >= 10)
        default:
            return tab;
    }
}
function categorisertotal(categorie, tab) {

    switch (+categorie) {
        case 1:
            return tab.filter((tr) => +affichercereale(tr).querySelector("td:nth-child(8)").textContent < 1)
        case 2:
            return tab.filter((tr) => +affichercereale(tr).querySelector("td:nth-child(5)").textContent < 50)
        case 3:
            return tab.filter((tr) => +affichercereale(tr).querySelector("td:nth-child(10)").textContent >= 25 && +affichercereale(tr).querySelector("td:nth-child(6)").textContent >= 10)
        default:
            return tab
    }
}

function tri(indextitle) {
    let doc = [...document.querySelectorAll("tbody>tr:not(tr:last-child)")]
    
    if (indextitle == 1 || indextitle ==11) {
        doc.sort((tra, trb) => {
            const nameA = tra.querySelector("td:nth-child(2)").textContent
            const nameB = trb.querySelector("td:nth-child(2)").textContent
            if (nameA < nameB) {
                return -1;
            }
            if (nameA > nameB) {
                return 1;
            }
            // names must be equal
            return 0;
        })
    }
    else {
        doc.sort(
            (tra, trb) =>
                parseInt(
                    trb.querySelector("td:nth-child(" + (parseInt(indextitle) + 1) + ")").textContent
                ) - parseInt(
                    tra.querySelector("td:nth-child(" + (parseInt(indextitle) + 1) + ")").textContent
                )
        );

    }
    document.querySelector("table").removeChild(document.querySelector("tbody"));
    const tbody = document.createElement("tbody")
    document.querySelector("table").appendChild(tbody);
    doc.forEach(element => {
        document.querySelector("tbody").appendChild(element);
    });
    moyenne()
}

function trier() {
    const titles = document.querySelectorAll("th>h2")
    for (let i = 0; i < titles.length; i++) {
        titles[i].addEventListener("click", async () => {
            tri(i);
        })
    }

}
trier();
//champ de recherche
document.querySelector("#recherche").addEventListener("input", async () => {
    active = [];
    document.querySelectorAll("#nutriscore>input").forEach(nutriscore => {
        if (nutriscore.checked) {
            remplissage(nutriscore);
        }
        else {
            vider(nutriscore);
        }
    })
    //change la catégorie
    if (active.length === 0) {
        affichagetotal(categorisertotal(document.querySelector("#cat").value, cereals))
    }

    else { //si filtres actifs
        active = categoriser(document.querySelector("#cat").value, active)
        affichertri()
    }

    //prise en compte de ce qui est écrit dans le champ de recherche
    let cereale = document.querySelector("#recherche").value;
    document.querySelectorAll("tbody td:nth-child(2)").forEach(td => {
        if (!td.textContent.toUpperCase().includes(cereale.toUpperCase())) {
            document.querySelector("tbody").removeChild(td.parentNode);
        }
    })
    moyenne();
});

//quand on filtre par composition
document.querySelector("#cat").addEventListener("change", async (e) => {
    active = [];
    document.querySelectorAll("#nutriscore>input").forEach(nutriscore => {
        if (nutriscore.checked) {
            remplissage(nutriscore);
        }
        else {
            vider(nutriscore);
        }
    })
    //change la catégorie
    if (active.length === 0) {
        affichagetotal(categorisertotal(document.querySelector("#cat").value, cereals))
    }
    else { //si filtres actifs
        const value = document.querySelector("select").value
        active = categoriser(value, active);
        affichertri();
    }
    let cereale = document.querySelector("#recherche").value;
    document.querySelectorAll("tbody td:nth-child(2)").forEach(td => {
        if (!td.textContent.toUpperCase().includes(cereale.toUpperCase())) {
            document.querySelector("tbody").removeChild(td.parentNode);
        }
    })
    moyenne()
})

//quand on filtre par nutriscore
document.querySelectorAll("#nutriscore>input").forEach(letter => {
    letter.addEventListener("click", async (e) => {
        active = [];
        document.querySelectorAll("#nutriscore>input").forEach(nutriscore => {
            if (nutriscore.checked) {
                remplissage(nutriscore);
            }
            else {
                vider(nutriscore);
            }
        })
        //change la catégorie
        if (active.length === 0) {
            affichagetotal(categorisertotal(document.querySelector("#cat").value, cereals))
        }

        else { //si filtres actifs
            active = categoriser(document.querySelector("#cat").value, active)
            affichertri()
        }

        //prise en compte de ce qui est écrit dans le champ de recherche
        let cereale = document.querySelector("#recherche").value;
        document.querySelectorAll("tbody td:nth-child(2)").forEach(td => {
            if (!td.textContent.toUpperCase().includes(cereale.toUpperCase())) {
                document.querySelector("tbody").removeChild(td.parentNode);
            }
        })
        moyenne();
    })
});

