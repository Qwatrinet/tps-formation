const response = await fetch("https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json");
const cards = await response.json();



cards.forEach(card => {
    let row = document.createElement("tr");
    for (const key in card) {
        let col = document.createElement("td");
        if (key == "description") {            
        }
        else {
            col.innerText = card[key];
            row.appendChild(col);
            if (key == "level") {
                row.append(document.createElement("td"))
            }

        }
    }
    document.querySelector("table").appendChild(row);       
});

let maxim = 0;
let playname = "";
let nbpart=""
cards.forEach(card => {
    if (+card.played > maxim) {
        maxim = parseInt(card.played);
        playname = card.name;
        nbpart = card.played;
    }
    
});
let grosGeek = document.createElement("p");
grosGeek.textContent = "plus gros joueur: " + playname + " nombre de parties: " + nbpart;
document.querySelector("div").appendChild(grosGeek);

let ratio = 0;
playname = "";
nbpart = 0;
let nbvic = 0;
cards.forEach(card => {
    if (parseInt(card.victory) / parseInt(card.defeat) > ratio) {
        ratio = parseInt(card.victory) / parseInt(card.defeat);
        playname = card.name;
        nbpart = card.played;
        nbvic = card.victory;
    }      
});
let crasseux = document.createElement("p");
crasseux.textContent = "meilleur joueur: " + playname + " nombre de parties: " + nbpart + " nombre de victoires: " + nbvic
document.querySelector("div").appendChild(crasseux);