import Distributeur from "./Distributeur.js";
const app = {
    data() {
        return {
            distributeur: new Distributeur(),

        };
    },
    computed: {
        enTrainDePayer() {
            return this.distributeur.paye == 0 ? "Attente paiement" : "Annuler";
        },
        pluriel() {
            if (this.distributeur.achats.length > 1) {
                return "s"
            }
            return
        },
        prixTotal() {
            let sum = 0
            for (const achat of this.distributeur.achats) {
                sum += achat.selection.tarif
            }
            return sum.toFixed(2)
        }
    },
    methods: {
        afficherSelection(boisson) {
            if (boisson.article.selection === true) {
                return "Sélectionné";
            }
            if (boisson.article.selection === false) {
                return "Sélectionner";
            }
            return "Rupture de stock";
        },

        ajouterPiece(event) {
            this.distributeur.insererMonnaie(event.target.dataset.value)
        },
        annulerSelection() {
            this.distributeur.annulerSelection(true);
        },
        selectBoisson(boisson) {
            this.distributeur.selectionner(boisson);
        },
        recupererBoisson() {
            this.distributeur.recupererBoisson();
        }
    },
    mounted() { },
};

Vue.createApp(app).mount("body");
