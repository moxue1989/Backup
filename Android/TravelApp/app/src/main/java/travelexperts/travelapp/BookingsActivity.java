package travelexperts.travelapp;

import android.app.Activity;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Arrays;

import travelexperts.travelapp.Adapters.BookingAdapter;
import travelexperts.travelapp.Async.AsyncBookings;
import travelexperts.travelapp.Fragments.DetailsFragment;
import travelexperts.travelapp.Models.Booking;

public class BookingsActivity extends Activity {

    private int custId;
    private ArrayList<Booking> bookings;
    private RecyclerView rvBookings;
    private RecyclerView.Adapter rvAdapter;
    private RecyclerView.LayoutManager rvLayoutManager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_bookings);
        Bundle extras = getIntent().getExtras();
        if (extras != null){
            custId = extras.getInt("custId");
            Toast.makeText(this,custId+"",Toast.LENGTH_LONG).show();
            new AsyncBookings(this).execute(custId);
        }
    }

    public void setBookings(Booking[] bookings) {
        this.bookings = new ArrayList<Booking>(Arrays.asList(bookings));
        rvAdapter = new BookingAdapter(this.bookings);
        rvBookings.setAdapter(rvAdapter);
    }

    @Override
    protected void onStart() {
        super.onStart();
        rvBookings = (RecyclerView) findViewById(R.id.rvBookingList);
        rvBookings.setHasFixedSize(true);
        rvLayoutManager = new LinearLayoutManager(this);
        rvBookings.setLayoutManager(rvLayoutManager);
    }

    public void showDetails(Booking b){
        //Toast.makeText(this,b.getBookingNo(),Toast.LENGTH_LONG).show();
        DetailsFragment fr = new DetailsFragment();
        Bundle bundle = new Bundle();
        bundle.putSerializable("booking", b);
        fr.setArguments(bundle);
        FragmentManager fm = getFragmentManager();
        FragmentTransaction fragmentTransaction = fm.beginTransaction();
        fragmentTransaction.replace(R.id.booking_fragment_place, fr);
        fragmentTransaction.commit();
    }
}
