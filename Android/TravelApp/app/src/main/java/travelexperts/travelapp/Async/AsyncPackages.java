package travelexperts.travelapp.Async;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;

import com.google.gson.Gson;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

import travelexperts.travelapp.BookingsActivity;
import travelexperts.travelapp.MainActivity;
import travelexperts.travelapp.Models.Booking;
import travelexperts.travelapp.Models.Package;

public class AsyncPackages extends AsyncTask<Integer, Integer, Package[]> {
    Context context;
    public AsyncPackages(Context c) {
        context = c;
    }

    @Override
    protected Package[] doInBackground(Integer... params) {
        try {
            String urlString = "https://travel-experts.appspot.com/api/packages";

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
            Package[] packages = gson.fromJson(jsonStr, Package[].class);
            connection.disconnect();
            for(Package p:packages){
                String imgUrl ="http://lorempixel.com/1400/800/nature/" + p.getPkgName();
                InputStream in = new java.net.URL(imgUrl).openStream();
                Bitmap img = BitmapFactory.decodeStream(in);
                p.setImage(img);
            }
            return packages;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
    @Override
    protected void onPostExecute(Package[] packages) {
        //Toast.makeText(context, bookings.length+"", Toast.LENGTH_LONG).show();
        MainActivity activity = (MainActivity) context;
        activity.loadPackages(packages);
        super.onPostExecute(packages);
    }
}
