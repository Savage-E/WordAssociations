package ru.vsu.wordassociations

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    private var instructions = ArrayList<String>()
    private var settings = ArrayList<String>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initializeSettings()
        //val set = TempFileWriter()
      //  set.writeSettings(applicationContext)
        btn_start.setOnClickListener {
            if (instructions.isEmpty() || settings.isEmpty()) {
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

            startActivityForResult(intent, 111)


        }
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)
        if (requestCode == 111 && resultCode
            == RESULT_OK
        ) {
            val b = data?.extras
            if (b != null) {
                val tempArray = b.getStringArrayList("settings") as ArrayList<String>
                if (tempArray.isNotEmpty()) {
                    settings = tempArray
                }
            } else {
                Toast.makeText(
                    this,
                    "Ошибка чтения файла с настройками",
                    Toast.LENGTH_SHORT
                ).show()
            }

            if (b != null) {
                val tempArray = b.getStringArrayList("instructions") as ArrayList<String>
                if (tempArray.isNotEmpty()) {
                    instructions = tempArray
                }

            } else {
                Toast.makeText(
                    this,
                    "Ошибка чтения файла с инструкцией",
                    Toast.LENGTH_SHORT
                ).show()
            }
        }

    }


    private fun initializeSettings() {
        val fileLoader = FileLoader()
        instructions = fileLoader.loadSavedSettings(applicationContext, 1)
        settings = fileLoader.loadSavedSettings(applicationContext, 2)

    }

}