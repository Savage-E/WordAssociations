package ru.vsu.wordassociations

import android.content.Intent
import android.net.Uri
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_settings.*

class SettingsActivity : AppCompatActivity() {
    private val SETTINGS: Int = 1
    private val INSTRUCTION: Int = 2
    private var settings = String()
    private var instructions = String()
    private lateinit var uri: Uri
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_settings)


        btn_load_settings.setOnClickListener {
            val intent = Intent()
            intent.type = "text/plain"
            intent.action = Intent.ACTION_GET_CONTENT
            startActivityForResult(Intent.createChooser(intent, "Select Instruction"), SETTINGS)
        }

        btn_load_instruction.setOnClickListener() {
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

    private fun upload(code: Int) {
        val fileLoader = FileLoader()
        when (code) {
            1 -> {
                settings = fileLoader.loadExternalFile(uri, applicationContext)
                Toast.makeText(this, settings, Toast.LENGTH_SHORT).show()
            }
            2 -> {
                instructions = fileLoader.loadExternalFile(uri, applicationContext)
                Toast.makeText(this, instructions, Toast.LENGTH_SHORT).show()
            }
        }


    }

    override fun onBackPressed() {


        val intent = Intent(this, MainActivity::class.java)
        intent.flags = Intent.FLAG_ACTIVITY_REORDER_TO_FRONT

        intent.putExtra("instructions", instructions)
        intent.putExtra("settings", settings)

        setResult(RESULT_OK, intent);
        startActivityIfNeeded(intent, 0)
        finish()
    }
}