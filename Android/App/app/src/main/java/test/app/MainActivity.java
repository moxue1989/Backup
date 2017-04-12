package test.app;


import android.databinding.DataBindingUtil;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import test.app.databinding.MainActivityBinding;

public class MainActivity extends AppCompatActivity {

    public static MainActivityBinding binding;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = DataBindingUtil.setContentView(this,R.layout.main_activity);
        User user = new User("Test ", "User");
        User user2 = new User("Test2 ", "User2");

        binding.setUser(user);
        binding.setMethods(new Methods());

//        final Button button = (Button) findViewById(R.id.button);
//        button.setOnClickListener(new View.OnClickListener() {
//            public void onClick(View view){
//                final User user3 = new User("Test3 ", "User3");
//                binding.setUser2(user3);
//                Intent intent = new Intent(this,)
//                startActivity(intent);
//            }
//        });
    }

    public void exit(View view){
        Methods.click(view);
    }

//    public void sendMessage(View view) {
//        final User user3 = new User("Test3 ", "User3");
//        binding.setUser2(user3);
//        Intent intent = new Intent(this,Result.class);
//        startActivity(intent);
//    }
}
