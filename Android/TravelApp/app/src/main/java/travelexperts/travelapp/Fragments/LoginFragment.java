package travelexperts.travelapp.Fragments;


import android.app.Fragment;
import android.os.Bundle;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;

import travelexperts.travelapp.Async.AsyncLogin;
import travelexperts.travelapp.R;


public class LoginFragment extends Fragment {

    private EditText etUser, etPass;
    private Button btnLogin;

    public LoginFragment() {
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_login, container, false);

        etUser = (EditText) view.findViewById(R.id.etUser);
        etPass = (EditText) view.findViewById(R.id.etPass);
        btnLogin = (Button) view.findViewById(R.id.btnLogin);
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                new AsyncLogin(v).execute(etUser.getText()+"", etPass.getText()+"");
            }
        });
        return view;
    }
}
