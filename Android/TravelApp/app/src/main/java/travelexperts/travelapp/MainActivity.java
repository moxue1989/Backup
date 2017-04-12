package travelexperts.travelapp;

import android.app.Activity;
import android.app.Fragment;
import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Arrays;

import travelexperts.travelapp.Adapters.PackageAdapter;
import travelexperts.travelapp.Async.AsyncPackages;
import travelexperts.travelapp.Fragments.LoginFragment;
import travelexperts.travelapp.Models.Package;


public class MainActivity extends Activity {

    private ArrayList<Package> packages;
    private RecyclerView rvPackages;
    private RecyclerView.Adapter rvAdapter;
    private RecyclerView.LayoutManager rvLayoutManager;

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.main_menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        Toast.makeText(this, item.getTitle(), Toast.LENGTH_LONG).show();
        Fragment fr = new LoginFragment();
        FragmentManager fm = getFragmentManager();
        fm.popBackStack();
        FragmentTransaction fragmentTransaction = fm.beginTransaction();
        fragmentTransaction.replace(R.id.main_fragment_place, fr).addToBackStack("login");
        fragmentTransaction.commit();
        return true;
    }

    @Override
    public void onBackPressed() {
        FragmentManager fm = getFragmentManager();
        int count = fm.getBackStackEntryCount();
        Toast.makeText(this, count+"", Toast.LENGTH_LONG).show();
        if(fm.getBackStackEntryCount() == 0) {
            this.finish();
        } else {
            fm.popBackStack();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        new AsyncPackages(this).execute();
    }

    @Override
    protected void onStart() {
        super.onStart();
        rvPackages = (RecyclerView) findViewById(R.id.rvPackageList);
        rvPackages.setHasFixedSize(true);
        rvLayoutManager = new LinearLayoutManager(this);
        rvPackages.setLayoutManager(rvLayoutManager);
    }

    public void LoggedIn(int custId){
        FragmentManager fm = getFragmentManager();
        fm.popBackStack();
        Intent intent = new Intent(this, BookingsActivity.class);
        intent.putExtra("custId", custId);
        startActivity(intent);
    }

    public void loadPackages(Package[] packages) {
        this.packages = new ArrayList<Package>(Arrays.asList(packages));
        rvAdapter = new PackageAdapter(this.packages);
        rvPackages.setAdapter(rvAdapter);
    }
}
