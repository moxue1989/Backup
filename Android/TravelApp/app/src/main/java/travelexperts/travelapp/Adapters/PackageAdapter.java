package travelexperts.travelapp.Adapters;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import java.text.SimpleDateFormat;
import java.util.ArrayList;

import travelexperts.travelapp.BookingsActivity;
import travelexperts.travelapp.Models.Booking;
import travelexperts.travelapp.Models.Package;
import travelexperts.travelapp.R;

/**
 * Created by 750118 on 3/3/2017.
 */

// Recycler view adapter
public class PackageAdapter extends RecyclerView.Adapter<PackageAdapter.ViewHolder>{

    private ArrayList<Package> packages;

    public static class ViewHolder extends RecyclerView.ViewHolder{
        public EditText etPackageName, etPackagePrice, etPackageStart, etPackageEnd;
        public ImageView ivPackageImage;

        public ViewHolder(View itemView) {
            super(itemView);
            etPackageName = (EditText) itemView.findViewById(R.id.etPackageName);
            etPackagePrice = (EditText) itemView.findViewById(R.id.etPackagePrice);
            etPackageStart= (EditText) itemView.findViewById(R.id.etPackageStart);
            etPackageEnd = (EditText) itemView.findViewById(R.id.etPackageEnd);
            ivPackageImage = (ImageView) itemView.findViewById(R.id.ivPackageImage);
        }
    }

    public PackageAdapter(ArrayList<Package> packages) {
        this.packages = packages;
    }

    @Override
    public PackageAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
;
        // attach OnClickListener to each view holder
        LinearLayout v = (LinearLayout) LayoutInflater.from(parent.getContext())
                .inflate(R.layout.textview_package, parent, false);
        ViewHolder vh = new ViewHolder(v);
        return vh;
    }

    @Override
    public void onBindViewHolder(PackageAdapter.ViewHolder holder, int position) {

        Package pack = packages.get(position);
        holder.etPackageName.setText(pack.getPkgName());
        holder.etPackagePrice.setText(pack.getPkgBasePrice().toString());

        SimpleDateFormat df = new SimpleDateFormat("dd/MM/yyyy");

        holder.etPackageStart.setText(df.format(pack.getPkgStartDate()));
        holder.etPackageEnd.setText(df.format(pack.getPkgEndDate()));
        holder.ivPackageImage.setImageBitmap(pack.getImage());

    }

    @Override
    public int getItemCount() {
        return packages.size();
    }

}
