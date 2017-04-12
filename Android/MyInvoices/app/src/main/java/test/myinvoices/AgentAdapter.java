package test.myinvoices;

import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by 750118 on 3/3/2017.
 */

public class AgentAdapter extends RecyclerView.Adapter<AgentAdapter.ViewHolder> {

    private ArrayList<Agent> mDataset;

    public static class ViewHolder extends RecyclerView.ViewHolder {
        public TextView mTextView;
        public TextView mTextView2;
        public ViewHolder(View itemView) {
            super(itemView);
            mTextView = (TextView) itemView;
            mTextView2 = (TextView) itemView;
        }
    }

    public AgentAdapter(ArrayList<Agent> mDataset) {
        this.mDataset = mDataset;
    }

    @Override
    public AgentAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {

        TextView v = (TextView) LayoutInflater.from(parent.getContext())
                .inflate(R.layout.my_text_view, parent, false);

        ViewHolder vh = new ViewHolder(v);
        return vh;
    }

    @Override
    public void onBindViewHolder(AgentAdapter.ViewHolder holder, int position) {
        holder.mTextView.setText(mDataset.get(position).getAgtFirstName());
        holder.mTextView2.setText(mDataset.get(position).getAgtLastName());
    }

    @Override
    public int getItemCount() {
        return mDataset.size();
    }


}
