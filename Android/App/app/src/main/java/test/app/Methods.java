package test.app;

import android.app.Activity;
import android.view.View;
import android.widget.Button;

import test.app.databinding.MainActivityBinding;

/**
 * Created by 750118 on 3/2/2017.
 */

public class Methods {

    public static void click(View view){
        MainActivity.binding.setUser(new User("Hello", "World"));
        view.setVisibility(View.GONE);
    }

    public void clicks(View view){
        MainActivity.binding.setUser(new User("Hello", "World"));

        ((Button)view).setText(view.getId() + "");
    }
}
