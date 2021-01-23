package ru.vsu.wordassociations

import android.app.AlertDialog
import android.content.DialogInterface
import android.os.Bundle
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_test.*
import kotlinx.android.synthetic.main.activity_test_options.*


class TestActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_test)
        val intent = getIntent()
        val option = intent.getStringExtra("option")
        val word = intent.getStringExtra("basic_word")
        val dataList = intent.getStringArrayListExtra("dataList")
        txtField_word.text = word
        btn_submit_word.setOnClickListener()
        {


            if (et_word.equals("")) {
                Toast.makeText(this, "Введите ассоциацию!", Toast.LENGTH_SHORT).show()
            } else {
                if (option.equals("Одно базовое слово")) {

                    if (dataList != null) {
                        dataList.add(et_word.text.toString())
                    }
                } else {
                    txtField_word.text = et_word.text
                    if (dataList != null) {
                        dataList.add(et_word.text.toString())
                    }
                    et_word.text?.clear()
                }
            }
        }
        btn_finish.setOnClickListener(){

        }
    }

}