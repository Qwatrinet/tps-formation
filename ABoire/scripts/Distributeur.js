import Article from "./Article.js";
export default class Distributeur {
  constructor() {
    this.boissons = [];
    this.commande = null;
    this.addDefaultArticles();
    this.selection = null;
    this.paye = 0;
    this.restantDu = 0;
    this.retourMonnaie = 0;
    this.achats = [];
    this.argentTombe = false
  }

  addArticle(article, stock) {
    if (this.boissons.find((b) => b.article.nom === article.nom)) {
      return;
    }

    this.boissons.push({ article, stock });
  }
  addDefaultArticles() {
    this.addArticle(new Article("Soda au Sucre Sucré au Sucre", 1.25), 20);
    this.addArticle(new Article("Vraie Eau", 1.05), 25);
    this.addArticle(new Article("Eau Contaminée", 1.15), 30);
    this.addArticle(new Article("Jus Divers", 1.25), 35);
    this.addArticle(new Article("Soda des Influençables", 1.25), 0);
    this.addArticle(new Article("Café dans ta Gueule", 1.35), 1);
    this.boissons.forEach((boisson) => {
      if (boisson.stock == 0) {
        boisson.article.selection = null;
      }
    });
  }

  selectionner(boisson) {
    this.boissons.forEach((b) => {
      if (b.article.nom == boisson.article.nom) {
        if (b.stock != 0) {
          b.article.selection = true;
          this.selection = boisson.article;
          this.restantDu = boisson.article.tarif;
        } else {
          this.annulerSelection(true);
          b.article.selection = null;
        }
      }
      else {
        b.article.selection = b.stock == 0 ? null : false;
      }
    });
  }

  insererMonnaie(somme) {
    somme = +somme;
    this.paye = (+this.paye + somme).toFixed(2);
    this.retourMonnaie = Math.max(this.paye - this.selection.tarif, 0).toFixed(
      2
    );
    this.restantDu = Math.max(this.selection.tarif - this.paye, 0).toFixed(2);
    this.retourMonnaie = Math.max(this.paye - this.selection.tarif, 0).toFixed(
      2
    );
  }

  annulerSelection(full) {
    this.selection = null;
    this.rembourser(full);
    this.paye = 0
    this.restantDu = 0
    for (const boisson of this.boissons) {
      boisson.article.selection = boisson.stock > 0 ? false : null

    }
  }

  recupererBoisson() {
    for (const boisson of this.boissons) {
      if (boisson.article.nom == this.selection.nom) {
        boisson.stock -= 1;
        this.achats.push({ selection: this.selection, date: Date.now() });
      }
    }
    this.annulerSelection(false)
  }

  rembourser(full) {
    this.argentTombe = (!full ? +this.retourMonnaie : +this.paye).toFixed(2);
    this.retourMonnaie = 0
    setTimeout(() => {
      this.argentTombe = 0;
    }, 3000)
      ;
  }
}
