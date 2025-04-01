package com.truite2312.furbymoches;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import java.util.ArrayList;

public class FurbyDatabaseHelper extends SQLiteOpenHelper {

    //Database info
    private static final String DATABASE_NAME = "furbyDatabase";
    private static final int DATABASE_VERSION = 1;

    //Nom de la table
    private static final String TABLE_FURBIES = "furbies";

    //Nom des attributs
    private static final String KEY_FURBY_ID = "id";
    private static final String KEY_NOM = "nom";
    private static final String KEY_PRENOM = "prénom";
    private static final String KEY_PHOTO = "photo";

    //L'instance pour le singleton
    private static FurbyDatabaseHelper sInstance;

    private FurbyDatabaseHelper(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    public static synchronized FurbyDatabaseHelper getInstance(Context context) {
        if (sInstance == null) {
            sInstance = new FurbyDatabaseHelper((context.getApplicationContext()));
        }
        return sInstance;
    }

    @Override
    public void onConfigure(SQLiteDatabase db) {
        super.onConfigure(db);
        db.setForeignKeyConstraintsEnabled(true);
    }

    //Database first creation
    @Override
    public void onCreate(SQLiteDatabase db) {
        String CREATE_FURBIES_TABLE = "CREATE TABLE " + TABLE_FURBIES + "(" +
                KEY_FURBY_ID + " INTEGER PRIMARY KEY," +
                KEY_NOM + " TEXT," +
                KEY_PRENOM + " TEXT," +
                KEY_PHOTO + " TEXT" + ")";
        db.execSQL(CREATE_FURBIES_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        if (oldVersion != newVersion) {
            db.execSQL("DROP TABLE IF EXISTS " + TABLE_FURBIES);
            onCreate(db);
        }
    }

    public void addFurby(Furby furby) {
        SQLiteDatabase db = getWritableDatabase();
        db.beginTransaction();
        try {
            ContentValues values = new ContentValues();
            values.put(KEY_NOM, furby.getNom());
            values.put(KEY_PRENOM, furby.getPrenom());
            values.put(KEY_PHOTO, furby.getPhoto());
            //id s'auto incrémente
            db.insertOrThrow(TABLE_FURBIES, null, values);
            db.setTransactionSuccessful();
        } catch (Exception e) {
            Log.d("ajoutIncorrect", "Une erreur est survenue lors de l'ajout à la base de données.");
        } finally {
            db.endTransaction();
            db.close();
        }
    }

    public ArrayList<Furby> getAllFurbies() {
        ArrayList<Furby> furbies = new ArrayList<>();
        String FURBIES_SELECT_QUERY = String.format("SELECT * FROM %s", TABLE_FURBIES);
        SQLiteDatabase db = getReadableDatabase();
        Cursor cursor = db.rawQuery(FURBIES_SELECT_QUERY, null);
        try {
            if (cursor.moveToFirst()) {
                do {
                    int indexNom = cursor.getColumnIndex(KEY_NOM);
                    int indexPrenom = cursor.getColumnIndex(KEY_PRENOM);
                    int indexPhoto = cursor.getColumnIndex(KEY_PHOTO);
                    if (indexNom >= 0 && indexPrenom >= 0 && indexPhoto >= 0) {
                        String nom = cursor.getString(indexNom);
                        String prenom = cursor.getString(indexPrenom);
                        String photo = cursor.getString(indexPhoto);
                        Furby newFurby = new Furby(nom, prenom, photo);
                        furbies.add(newFurby);
                    }
                } while (cursor.moveToNext());
            }
        } catch (Exception e) {
            Log.d("getError", "Impossible de récupérer le contenu de la base de données!");
        } finally {
            if (cursor != null && !cursor.isClosed()) {
                cursor.close();
            }
        }
        db.close();
        return furbies;
    }

    public int updateFurby(Furby furby) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(KEY_PHOTO, furby.getPhoto());
        values.put(KEY_NOM, furby.getNom());
        values.put(KEY_PRENOM, furby.getPrenom());

        return db.update(TABLE_FURBIES, values, KEY_NOM + " =?", new String[]{String.valueOf(furby.getNom())});
    }

    public void deleteFurby(Furby furby) {

        SQLiteDatabase db = this.getWritableDatabase();
        db.beginTransaction();
        try {
            db.delete(TABLE_FURBIES, KEY_NOM + "=?", new String[]{furby.getNom()});
            db.setTransactionSuccessful();

        } catch (Exception e) {
            Log.d("Destroy Exception", "Impossible de supprimer le furby!");
        } finally {
            db.endTransaction();

        }

    }

}
