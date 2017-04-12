package travelexperts.travelapp.Async;

import android.os.AsyncTask;
import android.view.View;
import android.widget.Toast;

import com.google.gson.Gson;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

import travelexperts.travelapp.MainActivity;
import travelexperts.travelapp.Models.Customer;

/**
 * Created by 750118 on 4/11/2017.
 */

public class AsyncLogin extends AsyncTask<String, Integer, Customer> {
    View view;
    public AsyncLogin(View v) {
        view = v;
    }

    @Override
    protected Customer doInBackground(String... params) {
        String user = params[0];
        String pass = params[1];

        try {
            String urlString = "https://travel-experts.appspot.com/api/customers/login";
            urlString += "?user=" + user + "&pass=" + pass;

            URL url = new URL(urlString);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            BufferedReader rd = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            StringBuilder responseStrBuilder = new StringBuilder();
            String inputStr;
            while ((inputStr = rd.readLine()) != null) {
                responseStrBuilder.append(inputStr);
            }
            String jsonStr = responseStrBuilder.toString();
            Gson gson = new Gson();
            Customer cust = gson.fromJson(jsonStr, Customer.class);
            connection.disconnect();
            /*Customer cust = new Customer();
            cust.setCustFirstName(jsonStr);
            cust.setCustLastName("hello");*/
            return cust;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
    @Override
    protected void onPostExecute(Customer customer) {
        if(customer == null){
            Toast.makeText(view.getContext(), "Wrong Username/Password", Toast.LENGTH_LONG).show();
        } else {
            //Toast.makeText(context, customer.getCustFirstName() + " " + customer.getCustLastName(), Toast.LENGTH_LONG).show();
            MainActivity activity = (MainActivity)view.getContext();
            activity.LoggedIn(customer.getCustomerId());
        }
        super.onPostExecute(customer);
    }
}
