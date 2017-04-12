package travelexperts.travelapp.Async;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.view.View;
import android.widget.Toast;

import com.google.gson.Gson;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

import travelexperts.travelapp.BookingsActivity;
import travelexperts.travelapp.MainActivity;
import travelexperts.travelapp.Models.Booking;
import travelexperts.travelapp.Models.Customer;

public class AsyncBookings extends AsyncTask<Integer, Integer, Booking[]> {
    Context context;
    public AsyncBookings(Context c) {
        context = c;
    }

    @Override
    protected Booking[] doInBackground(Integer... params) {
        int custId = params[0];

        try {
            String urlString = "https://travel-experts.appspot.com/api/bookings";
            urlString += "?id=" + custId;

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
            Booking[] bookings = gson.fromJson(jsonStr, Booking[].class);
            connection.disconnect();
            /*Customer cust = new Customer();
            cust.setCustFirstName(jsonStr);
            cust.setCustLastName("hello");*/
            return bookings;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
    @Override
    protected void onPostExecute(Booking[] bookings) {
        //Toast.makeText(context, bookings.length+"", Toast.LENGTH_LONG).show();
        BookingsActivity activity = (BookingsActivity) context;
        activity.setBookings(bookings);
        super.onPostExecute(bookings);
    }
}
