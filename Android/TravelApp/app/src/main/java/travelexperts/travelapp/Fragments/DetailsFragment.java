package travelexperts.travelapp.Fragments;


import android.app.Fragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

import travelexperts.travelapp.BookingsActivity;
import travelexperts.travelapp.Models.Booking;
import travelexperts.travelapp.R;

/**
 * A simple {@link Fragment} subclass.
 */
public class DetailsFragment extends Fragment {

    EditText etBookingId, etBookingDate, etBookingNo, etTravellerCount;
    private Booking booking;

    public DetailsFragment() {
        // Required empty public constructor
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_details, container, false);
        etBookingId = (EditText) view.findViewById(R.id.etBookingId);
        etBookingDate = (EditText) view.findViewById(R.id.etBookingDate);
        etBookingNo = (EditText) view.findViewById(R.id.etBookingNo);
        etTravellerCount = (EditText) view.findViewById(R.id.etTravellerCount);
        booking = (Booking) getArguments().getSerializable("booking");
        return view;
    }

    @Override
    public void onStart() {
        super.onStart();
        Date date = new Date(booking.getBookingDate());
        SimpleDateFormat df = new SimpleDateFormat("dd/MM/yyyy");

        etBookingDate.setText(df.format(date));
        etBookingId.setText(booking.getBookingId()+"");
        etBookingNo.setText(booking.getBookingNo());
        etTravellerCount.setText(booking.getTravelerCount()+"");
    }
}
