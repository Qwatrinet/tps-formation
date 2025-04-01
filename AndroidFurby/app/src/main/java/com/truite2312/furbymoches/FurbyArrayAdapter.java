package com.truite2312.furbymoches;

import android.content.Context;
import android.net.Uri;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class FurbyArrayAdapter extends ArrayAdapter<Furby> {
    private final ArrayList<Furby> list_furby;

    public FurbyArrayAdapter(Context context, ArrayList<Furby> furbies) {
        super(context, R.layout.furby_layout, furbies);
        list_furby = furbies;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {

        if (view == null) {
            LayoutInflater inflater = (LayoutInflater) getContext().getSystemService((Context.LAYOUT_INFLATER_SERVICE));
            view = inflater.inflate(R.layout.furby_layout, null);
        }
        Furby furbyOFItem = list_furby.get(i);
        if (furbyOFItem != null) {
            TextView nomView = (TextView) view.findViewById((R.id.view_nom));
            TextView prenomView = (TextView) view.findViewById(R.id.view_prenom);
            ImageView photoView = (ImageView) view.findViewById(R.id.imageView2);

            if (nomView != null) {
                nomView.setText("Nom: " + furbyOFItem.getNom());
            }

            if (prenomView != null) {
                prenomView.setText("Prenom: " + furbyOFItem.getPrenom());
            }

            if (photoView != null) {
                if (furbyOFItem.getPhoto().isEmpty()) {
                    photoView.setImageDrawable(view.getResources().getDrawable(R.drawable.truite, view.getContext().getTheme()));
                } else {
                    photoView.setImageURI(Uri.parse(furbyOFItem.getPhoto()));
                }
            }
        }

        return view;
    }
}


