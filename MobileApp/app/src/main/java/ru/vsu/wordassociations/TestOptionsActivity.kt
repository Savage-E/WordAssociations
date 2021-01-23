package ru.vsu.wordassociations

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.AutoCompleteTextView
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_test_options.*
import kotlinx.android.synthetic.main.activity_user_data.*

class TestOptionsActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_test_options)

        val items = listOf("Цепочка ассоциаций", "Одно базовое слово")
        val adapter = ArrayAdapter(this, R.layout.list_item, R.id.list_item, items)
        val intent = getIntent()
        val dataList = intent.getStringArrayListExtra("dataList")
        (txtField_option.editText as? AutoCompleteTextView)?.setAdapter(adapter)
        btn_submit_options.setOnClickListener(){
            if (et_basic_word.text.toString().isEmpty() || tv_option.text.toString().isEmpty())
            {
                Toast.makeText(this, "Введите базовое слово и выберите режим работы!", Toast.LENGTH_SHORT).show()
            }
            else
            {
                val intent = Intent(this, TestActivity::class.java)
                if (dataList != null) {
                    dataList.add(et_basic_word.text.toString())
                }
                if (dataList != null) {
                    dataList.add(tv_option.text.toString())
                }
                intent.putExtra("dataList",dataList)
                intent.putExtra("basic_word", et_basic_word.text.toString())
                intent.putExtra("option", tv_option.text.toString())
                startActivity(intent)
                finish()
            }
        }
    }

}