package com.truite2312.furbymoches;


import java.io.Serializable;

public class Furby implements Serializable {
    private String nom;
    private String prenom;

    private String photo;

    public Furby(String nom, String prenom, String photo) {
        this.nom = nom;
        this.prenom = prenom;
        this.photo = photo;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }

    public String getPhoto() {
        return photo;
    }

    public void setPhoto(String photo) {
        this.photo = photo;
    }
}
