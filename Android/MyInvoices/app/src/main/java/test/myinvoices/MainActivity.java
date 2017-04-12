package test.myinvoices;

import android.app.Activity;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;

import java.util.ArrayList;

public class MainActivity extends Activity {

    private RecyclerView mRecyclerView;
    private RecyclerView.Adapter mAdapter;
    private RecyclerView.LayoutManager mLayoutManager;
    private ArrayList<Agent> agents = null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        mRecyclerView = (RecyclerView) findViewById(R.id.my_recycler_view);
        mRecyclerView.setHasFixedSize(true);
        mLayoutManager = new LinearLayoutManager(this);
        mRecyclerView.setLayoutManager(mLayoutManager);

        agents = new ArrayList<Agent>();

        for(int i = 0; i < 600; i++){
            String text = "Agent " + i;
            String text2 = "Last "+ i;
            Agent agent = new Agent();
            agent.setAgtFirstName(text);
            agent.setAgtLastName(text2);
            agents.add(agent);
        }

        mAdapter = new AgentAdapter(agents);
        mRecyclerView.setAdapter(mAdapter);


    }

    public void ShowFrag(View view){
        FragmentManager fragmentManager = getFragmentManager();
        FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();

        myFragment frag = new myFragment();
        fragmentTransaction.add(R.id.fragContainer,frag);
        fragmentTransaction.commit();
    }
}

