package ru.vsu.wordassociations

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_test.*


class TestActivity : AppCompatActivity() {
    var settings = ArrayList<String>()
    var instructions = ArrayList<String>()
    var dataList = ArrayList<String>()
    var option = String()
    var chainNumber = 0
    var count = 0
    var currentIndex = 0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_test)
        val intent = intent
        option = intent.getStringExtra("option").toString()
        instructions = intent.getStringArrayListExtra("instructions") as ArrayList<String>
        dataList = intent.getStringArrayListExtra("dataList") as ArrayList<String>
        settings = intent.getStringArrayListExtra("settings") as ArrayList<String>

      //  textField_instruction.text = instruction.toString()

        txtField_word.text = "Word1"
        btn_submit_word.setOnClickListener()
        {


            if (et_word.text.toString() == "") {
                Toast.makeText(this, "Введите ассоциацию!", Toast.LENGTH_LONG).show()
            } else {
                if (option == "Звезда") {

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
                    fileWriter.writeRecord(dataList, applicationContext)
                }
                finish()
            }

            builder.setNegativeButton(android.R.string.no) { dialog, which ->

            }

            builder.setNeutralButton("Начать заново") { dialog, which ->


                val intent = Intent(this, MainActivity::class.java)
                val fileWriter = WordWriter()
                if (dataList != null) {
                    fileWriter.writeRecord(dataList, applicationContext)
                }
                startActivity(intent)
                finish()
            }
            builder.show()
        }
        fun initializeValues() {
            if (option == "Звезда") {

            } else {

            }
        }
    }
}

