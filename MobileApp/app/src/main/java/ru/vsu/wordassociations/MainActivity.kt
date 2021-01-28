package ru.vsu.wordassociations

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import kotlinx.android.synthetic.main.activity_main.*
import ru.vsu.wordassociations.R

import ru.vsu.wordassociations.UserDataActivity

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        btn_start.setOnClickListener() {
            val intent = Intent(this, UserDataActivity::class.java)
            startActivity(intent)
            finish()
        }
        btn_settings.setOnClickListener(){
            val intent = Intent(this, SettingsActivity::class.java)
            startActivity(intent)

        }
    }

}