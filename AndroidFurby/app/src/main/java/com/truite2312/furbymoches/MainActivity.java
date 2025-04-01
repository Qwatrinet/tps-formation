package com.truite2312.furbymoches;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    ArrayList<Furby> initialFurby;

    //ce qu'on fait au retour de l'activité
    ActivityResultLauncher<Intent> mStartForResult = registerForActivityResult(new ActivityResultContracts.StartActivityForResult(), result -> {
        if (result.getResultCode() == Activity.RESULT_OK) {
            Intent intent = result.getData();
            String nom = intent.getStringExtra("nom");
            String prenom = intent.getStringExtra("prenom");
            String photo = intent.getStringExtra("photo");

            Furby furbytoAdd = new Furby(nom, prenom, photo);
            //initialFurby.add(furbytoAdd);


            FurbyDatabaseHelper databaseHelper = FurbyDatabaseHelper.getInstance(this);
            databaseHelper.addFurby(furbytoAdd);
            initialFurby = databaseHelper.getAllFurbies();

            ListView listView = this.findViewById(R.id.listViewFurbies);
            listView.setAdapter(new FurbyArrayAdapter(this, initialFurby));

            this.registerForContextMenu(listView);
        }
    });

    @Override
    protected void onSaveInstanceState(Bundle out_state) {
        out_state.putSerializable("initialFurby", initialFurby);
        super.onSaveInstanceState(out_state);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ListView listView = this.findViewById(R.id.listViewFurbies);
        Button addFurby = this.findViewById(R.id.buttonAjouterPersonne);
        initialFurby = new ArrayList<Furby>();

//        if (savedInstanceState == null) {
//            initialFurby.add(new Furby("Truite", "Bob", ""));
//            initialFurby.add(new Furby("Bon", "Jean", ""));
//
//        } else {
//            Class<ArrayList<Furby>> clazz = (Class<ArrayList<Furby>>) initialFurby.getClass();
//            initialFurby = savedInstanceState.getSerializable("initialFurby", clazz);
//        }


        FurbyDatabaseHelper databaseHelper = FurbyDatabaseHelper.getInstance(this);
        initialFurby = databaseHelper.getAllFurbies();


        listView.setAdapter(new FurbyArrayAdapter(this, initialFurby));

        registerForContextMenu(listView);
        addFurby.setOnClickListener(v -> {
            mStartForResult.launch(new Intent(this, AjouterFurbyActivity.class));
        });
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_listview_furbies, menu);
    }


    @Override
    public boolean onContextItemSelected(MenuItem item) {
        AdapterView.AdapterContextMenuInfo menuInfo = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        final int copier = R.id.buttonCopier;
        int suppr = R.id.boutonSupprimer;
        ListView listView = this.findViewById(R.id.listViewFurbies);

        if (item.getItemId() == copier) {
            Toast.makeText(getApplicationContext(), "Copie: ID " + menuInfo.id + ", position " + menuInfo.position, Toast.LENGTH_SHORT).show();
            return true;
        } else if (item.getItemId() == suppr) {
            Toast.makeText(getApplicationContext(), "Supprimer: ID " + menuInfo.id + ", position " + menuInfo.position, Toast.LENGTH_SHORT).show();
            FurbyArrayAdapter faa = (FurbyArrayAdapter) listView.getAdapter();
            Furby fASuppr = faa.getItem(menuInfo.position);
            faa.remove(fASuppr);
            FurbyDatabaseHelper databaseHelper = FurbyDatabaseHelper.getInstance(this);
            databaseHelper.deleteFurby(fASuppr);
            initialFurby = databaseHelper.getAllFurbies();

            faa.notifyDataSetChanged();
            return true;
        } else {
            return false;
        }
    }
}