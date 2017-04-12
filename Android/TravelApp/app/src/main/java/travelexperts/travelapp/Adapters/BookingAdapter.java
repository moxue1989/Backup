package travelexperts.travelapp.Adapters;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.util.ArrayList;

import travelexperts.travelapp.BookingsActivity;
import travelexperts.travelapp.Models.Booking;
import travelexperts.travelapp.R;

/**
 * Created by 750118 on 3/3/2017.
 */

// Recycler view adapter
public class BookingAdapter extends RecyclerView.Adapter<BookingAdapter.ViewHolder>{

    private ArrayList<Booking> bookings;

    public static class ViewHolder extends RecyclerView.ViewHolder{
        public TextView mTextView;
        public ViewHolder(View itemView) {
            super(itemView);
            mTextView = (TextView) itemView;
        }
    }

    public BookingAdapter(ArrayList<Booking> bookings) {
        this.bookings = bookings;
    }

    @Override
    public BookingAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
;
        // attach OnClickListener to each view holder
        TextView v = (TextView) LayoutInflater.from(parent.getContext())
                .inflate(R.layout.textview_booking, parent, false);
        v.setOnClickListener(new MyOnClickListener());
        ViewHolder vh = new ViewHolder(v);
        return vh;
    }

    @Override
    public void onBindViewHolder(BookingAdapter.ViewHolder holder, int position) {

        Booking booking = bookings.get(position);
        holder.mTextView.setText(booking.toString());
    }

    @Override
    public int getItemCount() {
        return bookings.size();
    }

    // display selected agent info
    private class MyOnClickListener implements View.OnClickListener {
        @Override
        public void onClick(View v) {
            TextView view = (TextView) v;
            RecyclerView rv = (RecyclerView)v.getParent();
            int pos = rv.getChildAdapterPosition(view);
            Booking booking = bookings.get(pos);
            BookingsActivity c = (BookingsActivity)view.getContext();
            c.showDetails(booking);
        }
    }
}
