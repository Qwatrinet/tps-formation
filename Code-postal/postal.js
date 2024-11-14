const response = await fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json");
const cities = await response.json();


document.querySelector("#recherche").addEventListener("input", async () => {
    let code = document.querySelector("#recherche").value;
    document.querySelector("#code-postal").innerHTML = ""; /*clear les options*/
    if (code.length > 0 && code.length<6 && 0+code!==NaN) {
        cities.forEach(city => {
            if (city.codePostal.substring(0, code.length) == code) {
                let monoption = document.createElement("option");
                monoption.value = city.nomCommune;
                monoption.innerText = city.codePostal;
                document.querySelector("#code-postal").appendChild(monoption);
            }
        });
    }
    
    if (code.length == 5 && !isNaN(code)) {
        document.querySelector("button").removeAttribute("disabled");
    }
    if (!(code.length == 5 && !isNaN(code))) {
        document.querySelector("button").setAttribute("disabled",true);
    }
    if (isNaN(code)) {
        document.querySelector("button").removeAttribute("disabled");
    }
})



document.querySelector("button").addEventListener("click", async () => {
    document.querySelector("div").innerHTML = "";
    if (isNaN(document.querySelector("#recherche").value)) {  
        let res = cities.find(city => city.nomCommune == document.querySelector("#recherche").value)
        let bob = document.createElement("p");
        bob.textContent = "code postal: " + res.codePostal + " /nom: " + res.nomCommune + " /code commune: " + res.codeCommune;
        document.querySelector("div").appendChild(bob);
    }
    else {
        let res = cities.filter(city => city.codePostal == document.querySelector("#recherche").value);
        res.forEach(city => {
            let bob = document.createElement("p");
            bob.textContent = "code postal: "+city.codePostal + " /nom: " + city.nomCommune + " /code commune: " + city.codeCommune;
            document.querySelector("div").appendChild(bob);
        })
    }
})
