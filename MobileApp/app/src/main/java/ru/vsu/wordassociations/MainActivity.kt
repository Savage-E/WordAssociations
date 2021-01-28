package ru.vsu.wordassociations

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    private var instructions = String()
    private var settings = String()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initializeSettings()

        btn_start.setOnClickListener() {
            if (instructions == "null" || settings == "null") {
                Toast.makeText(
                    this,
                    "Отутствуют настройка и инструкция, добавьте их, нажав на кнопку Настройка",
                    Toast.LENGTH_SHORT
                ).show()
            } else {
                val intent = Intent(this, UserDataActivity::class.java)
                intent.putExtra("settings", settings)
                intent.putExtra("instructions", instructions)
                startActivity(intent)
                finish()
            }
        }
        btn_settings.setOnClickListener {
            val intent = Intent(this, SettingsActivity::class.java)
            startActivity(intent)

        }
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)

        settings = intent.getStringExtra("settings").toString()
        instructions = intent . getStringExtra ("instructions").toString()
    }


    private fun initializeSettings() {
        val fileLoader = FileLoader()
        settings = fileLoader.loadInternalFile(applicationContext, 2)
        instructions = fileLoader.loadInternalFile(applicationContext, 2)

    }

}