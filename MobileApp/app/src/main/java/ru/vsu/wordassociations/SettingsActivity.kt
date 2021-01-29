package ru.vsu.wordassociations

import android.content.Intent
import android.net.Uri
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_settings.*

class SettingsActivity : AppCompatActivity() {
    private val SETTINGS: Int = 1
    private val INSTRUCTION: Int = 2
    private var settings = ArrayList<String>()
    private var instructions = ArrayList<String>()
    private lateinit var uri: Uri
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_settings)


        btn_load_settings.setOnClickListener {
            val intent = Intent()
            intent.type = "text/plain"
            intent.action = Intent.ACTION_GET_CONTENT
            startActivityForResult(Intent.createChooser(intent, "Select settings"), SETTINGS)
        }

        btn_load_instruction.setOnClickListener {
            val intent = Intent()
            intent.type = "text/plain"
            intent.action = Intent.ACTION_GET_CONTENT
            startActivityForResult(Intent.createChooser(intent, "Select Instruction"), INSTRUCTION)
        }

    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {

        if (resultCode == RESULT_OK) {
            if (requestCode == SETTINGS) {

                uri = data!!.data!!
                upload(SETTINGS)

            }
            if (requestCode == INSTRUCTION) {
                uri = data!!.data!!
                upload(INSTRUCTION)
            }
        }

        super.onActivityResult(requestCode, resultCode, data)
    }
    //Загружаем выбранные в файл менджере файлы в наши переменные настроек и инструкции.
    private fun upload(code: Int) {
        val fileLoader = FileLoader()
        when (code) {
            1 -> {
                settings = fileLoader.loadFiles(uri, applicationContext)

            }
            2 -> {
                instructions = fileLoader.loadFiles(uri, applicationContext)

            }
        }


    }
    //Передаем данные при нажатии кнопки назад.
    override fun onBackPressed() {
        val intent = Intent()
        intent.putExtra("instructions", instructions)
        intent.putExtra("settings", settings)

        setResult(RESULT_OK, intent)
        finish()
    }
}