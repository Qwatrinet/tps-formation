package com.truite2312.hellolesnuls;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onSaveInstanceState(Bundle out_state) {
        EditText value = findViewById(R.id.editTextNumber);
        out_state.putString("number", value.getText().toString());
        super.onSaveInstanceState(out_state);
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        EditText value = findViewById(R.id.editTextNumber);
        Button inc = findViewById(R.id.buttoninc);
        Button dec = findViewById(R.id.buttondec);
        Button quit = findViewById(R.id.buttonQuit);

        if (savedInstanceState != null) {
            String savedText = savedInstanceState.getString("number");
            value.setText(savedText);
        }

        quit.setOnClickListener(v -> System.exit(0));

        inc.setOnClickListener(v -> {
            String text = value.getText().toString();
            if (!text.isEmpty()) {
                try {
                    int actualValue = Integer.parseInt(text);

                    ++actualValue;
                    //value.setText(Integer.toString(actualValue));
                    value.setText(String.format("%d", actualValue));
                } catch (Exception e) {
                    Toast.makeText(this, "Le nombre entré dépasse la limite!", Toast.LENGTH_LONG).show();
                }

            }

        });

        dec.setOnClickListener(v -> {
            String text = value.getText().toString();
            try {
                if (!text.isEmpty()) {
                    int actualValue = Integer.parseInt(text);
                    --actualValue;
                    value.setText(String.format("%d", actualValue));
                }
            } catch (Exception e) {
                Toast.makeText(this, "Le nombre entré dépasse la limite!", Toast.LENGTH_LONG).show();
            }

        });

    }


}