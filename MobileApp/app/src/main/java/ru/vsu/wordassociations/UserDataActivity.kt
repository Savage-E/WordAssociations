package ru.vsu.wordassociations

import android.content.Intent
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.AutoCompleteTextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_user_data.*


class UserDataActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_user_data)
        val items = listOf("Мужской", "Женский")
        val itemsOption = listOf("Цепочка ассоциаций", "Звезда")
        val adapter = ArrayAdapter(this, R.layout.list_item, R.id.list_item, items)
        (txtField_gender.editText as? AutoCompleteTextView)?.setAdapter(adapter)
        val adapter2 = ArrayAdapter(this, R.layout.list_item, R.id.list_item, items)
        (txtField_option.editText as? AutoCompleteTextView)?.setAdapter(adapter2)

        btn_submit_user_data.setOnClickListener() {
            if (et_age.text.toString().isEmpty() || et_last_name.text.toString().isEmpty()
                || et_name.text.toString().isEmpty() || tv_gender.text.toString().isEmpty()
            ) {
                Toast.makeText(this, "Введите Имя, Фамилию, пол и возраст!", Toast.LENGTH_SHORT)
                    .show()
            } else {
                var dataList = ArrayList<String>()
                dataList.add(et_name.text.toString())
                dataList.add(et_last_name.text.toString())
                dataList.add(et_patronymic.text.toString())
                dataList.add(et_age.text.toString())
                dataList.add(tv_gender.text.toString())


                val intent = Intent(this, TestActivity::class.java)
                intent.putExtra("dataList", dataList)
                intent.putExtra("option",tv_option.text.toString())
                startActivity(intent)
                finish()
            }
        }

    }
}