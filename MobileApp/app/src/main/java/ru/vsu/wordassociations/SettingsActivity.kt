package ru.vsu.wordassociations

import android.content.Intent
import android.net.Uri
import android.os.Bundle
import android.view.View
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_settings.*

class SettingsActivity : AppCompatActivity() {
    val SETTINGS: Int = 1
    val INSTRUCTION: Int = 1
    var settings = String()
    var instructions = String()
    lateinit var uri: Uri
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_settings)


        btn_load_settings.setOnClickListener() { view: View? ->
            val intent = Intent()
            intent.setType("text/plain")
            intent.setAction(Intent.ACTION_GET_CONTENT)
            startActivityForResult(Intent.createChooser(intent, "Select Instruction"), SETTINGS)
        }

        btn_load_instruction.setOnClickListener() { view: View? ->
            val intent = Intent()
            intent.setType("text/plain")
            intent.setAction(Intent.ACTION_GET_CONTENT)
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

    private fun upload(code: Int) {
        val fileLoader = FileLoader()
        when (code) {
            SETTINGS -> {
                settings = fileLoader.loadFile(uri, applicationContext)
                Toast.makeText(this, settings, Toast.LENGTH_SHORT).show()
            }
            INSTRUCTION -> {
                instructions = fileLoader.loadFile(uri, applicationContext)
                Toast.makeText(this, instructions, Toast.LENGTH_SHORT).show()
            }
        }


    }
}