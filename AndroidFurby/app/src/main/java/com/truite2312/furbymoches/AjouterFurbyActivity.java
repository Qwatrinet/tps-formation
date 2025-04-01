package com.truite2312.furbymoches;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AppCompatActivity;

public class AjouterFurbyActivity extends AppCompatActivity {
    Uri selectedImage = null;
    ActivityResultLauncher<Intent> mStartForResult = registerForActivityResult(new ActivityResultContracts.StartActivityForResult(), result -> {
        if (result.getResultCode() == Activity.RESULT_OK) {
            Intent intent = result.getData();
            selectedImage = intent.getData();

            ImageView avatar = this.findViewById(R.id.imageAvatar);

            if (selectedImage != null) {
                avatar.setImageURI(selectedImage);
            }


        }
    });

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ajouter_furby);

        Button valider = this.findViewById(R.id.boutonValid);
        ImageView avatar = this.findViewById(R.id.imageAvatar);

        avatar.setOnClickListener(v -> {
            mStartForResult.launch(new Intent(Intent.ACTION_OPEN_DOCUMENT, MediaStore.Images.Media.EXTERNAL_CONTENT_URI));
        });


        valider.setOnClickListener(v -> {
            Intent intent = getIntent();
            EditText valueNom = findViewById(R.id.editTexTNom);
            EditText valuePrenom = findViewById(R.id.editTextPrenom);

            String nom = valueNom.getText().toString();
            String prenom = valuePrenom.getText().toString();
            String photo = "";
            if (selectedImage != null) {
                this.getContentResolver().takePersistableUriPermission(selectedImage, Intent.FLAG_GRANT_READ_URI_PERMISSION);
                photo = selectedImage.toString();
            }

            intent.putExtra("nom", nom);
            intent.putExtra("prenom", prenom);
            intent.putExtra("photo", photo);
            setResult(RESULT_OK, intent);
            finish();
        });
    }
}