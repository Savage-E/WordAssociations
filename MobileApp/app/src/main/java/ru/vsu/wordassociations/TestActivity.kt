package ru.vsu.wordassociations

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_test.*



class TestActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_test)
        val intent = intent
        val option = intent.getStringExtra("option")

        val dataList = intent.getStringArrayListExtra("dataList")
        txtField_word.text = "Word1"
        btn_submit_word.setOnClickListener()
        {


            if (et_word.text.toString() == "") {
                Toast.makeText(this, "Введите ассоциацию!", Toast.LENGTH_SHORT).show()
            } else {
                if (option.equals("Звезда")) {

                    dataList?.add(et_word.text.toString())
                } else {
                    txtField_word.text = et_word.text
                    dataList?.add(et_word.text.toString())
                }
                et_word.text?.clear()
            }
        }
        btn_finish.setOnClickListener() {
            val builder = AlertDialog.Builder(this)
            builder.setTitle("Внимание!")
            builder.setMessage("Вы дейстительно завершить?")


            builder.setPositiveButton(android.R.string.yes) { dialog, which ->

                val fileWriter = WordWriter()
                if (dataList != null) {
                    fileWriter.write(dataList, applicationContext)
                }
                finish()
            }

            builder.setNegativeButton(android.R.string.no) { dialog, which ->

            }

            builder.setNeutralButton("Начать заново") { dialog, which ->


                val intent = Intent(this, MainActivity::class.java)
                val fileWriter = WordWriter()
                if (dataList != null) {
                    fileWriter.write(dataList, applicationContext)
                }
                startActivity(intent)
                finish()
            }
            builder.show()
        }
    }
}

