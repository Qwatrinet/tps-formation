const response = await fetch("https://arfp.github.io/tp/web/javascript2/03-employees/employees.json");
const temp = (await response.json()).data;


function calcEMail(employe) {
    const name = employe.employee_name.split(" ");
    return name[0][0].toLowerCase() + "." + name[1].toLowerCase() + "@email.com"
}

function calcSalaireMensuel(employe) {
    let sal = employe.employee_salary;
    sal = (sal / 12).toFixed(2)
    return sal;
}


function calcNaissance(employe) {
    const age = employe.employee_age
    return new Date().getFullYear() - age
}

function afficheremploye(employe) {
    const tr = document.createElement("tr");
    const id = document.createElement("td");
    id.textContent = employe.id;
    tr.appendChild(id);
    const ename = document.createElement("td");
    ename.textContent = employe.employee_name;
    tr.appendChild(ename);
    const email = document.createElement("td");
    email.textContent = calcEMail(employe);
    tr.appendChild(email);
    const salaire = document.createElement("td");
    salaire.classList.add("argent")
    salaire.textContent = calcSalaireMensuel(employe);
    tr.appendChild(salaire);
    const anneeNaissance = document.createElement("td");
    anneeNaissance.textContent = calcNaissance(employe);
    tr.appendChild(anneeNaissance)
    const td = document.createElement("td");
    const duplButton = document.createElement("button");
    duplButton.setAttribute("class", "duplicate")
    duplButton.addEventListener("click", function (e) {
        temp.push({ ...employe })

        const bob=temp.toSorted((a, b) => b.id - a.id)
        temp[temp.length - 1].id = bob[0].id+1
        resetaffichage()
        if (temp.length > 0) {
            temp.forEach(employe => {
                document.querySelector("tbody").appendChild(afficheremploye(employe))

            });
            document.querySelector("tbody").appendChild(afficherTotal())
        }
        else {
            alert("No employees found...")
        }
    })
    duplButton.textContent = "Duplicate"
    const supprButton = document.createElement("button");
    supprButton.setAttribute("class", "delete")
    supprButton.textContent = "Delete"
    supprButton.addEventListener("click", function (e) { 
        temp.splice(temp.indexOf(employe),1)
        resetaffichage()
        if (temp.length > 0) {
            temp.forEach(employe => {
                document.querySelector("tbody").appendChild(afficheremploye(employe))

            });
            document.querySelector("tbody").appendChild(afficherTotal())
        }
        else {
            alert("no Shrek found")
        }
    }) 
    td.appendChild(duplButton)
    td.appendChild(supprButton)
    tr.appendChild(td)

    return tr
}

function afficherTotal() {
    const tr = document.createElement("tr");
    const nbEmp = temp.length;
    const nbtot = document.createElement("td")
    nbtot.textContent = temp.length
    tr.appendChild(nbtot)
    tr.appendChild(document.createElement("td"))
    tr.appendChild(document.createElement("td"))
    let saltotal = 0
    temp.forEach(employe => {
        saltotal += +calcSalaireMensuel(employe)
    })
    const tdsaltotal = document.createElement("td")
    tdsaltotal.textContent = saltotal.toFixed(2)
    tdsaltotal.classList.add("argent")
    tr.appendChild(tdsaltotal)
    tr.appendChild(document.createElement("td"))
    tr.appendChild(document.createElement("td"))
    return tr

}

function resetaffichage() {
    document.querySelector("tbody").remove()
    const tbody=document.createElement("tbody")
    document.querySelector("table").append(tbody)
}

function triasc() {
    temp.sort((a, b) => a.employee_salary - b.employee_salary)
}

function tridesc() {
    temp.sort((a, b) => b.employee_salary - a.employee_salary)
}


const btntri = document.querySelector("#triable")
btntri.addEventListener("click", function (e) { 
    if (btntri.classList.contains("triasc")) {
        tridesc()
        resetaffichage()
        if (temp.length > 0) {
            temp.forEach(employe => {
                document.querySelector("tbody").appendChild(afficheremploye(employe))

            });
            document.querySelector("tbody").appendChild(afficherTotal())
        }
        else {
            alert("No employees found...")
        }
        btntri.classList.remove("triasc")
        btntri.classList.add("tridesc")
    }
    else if (btntri.classList.contains("tridesc")) {
        triasc()
        resetaffichage()
        if (temp.length > 0) {
            temp.forEach(employe => {
                document.querySelector("tbody").appendChild(afficheremploye(employe))

            });
            document.querySelector("tbody").appendChild(afficherTotal())
        }
        else {
            alert("No employees found...")
        }
        btntri.classList.remove("tridesc")
        btntri.classList.add("triasc")
    }
    else {
        triasc()
        resetaffichage()
        if (temp.length > 0) {
            temp.forEach(employe => {
                document.querySelector("tbody").appendChild(afficheremploye(employe))

            });
            document.querySelector("tbody").appendChild(afficherTotal())
        }
        else {
            alert("No employees found...")
        }
        btntri.classList.add("triasc") 
    }
})


if (temp.length > 0) {
    temp.forEach(employe => {
        document.querySelector("tbody").appendChild(afficheremploye(employe))

    });
    document.querySelector("tbody").appendChild(afficherTotal())
}
else {
    alert("No employees found...")
}


