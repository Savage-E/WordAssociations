package ru.vsu.wordassociations

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.AutoCompleteTextView
import androidx.core.content.ContentProviderCompat.requireContext
import kotlinx.android.synthetic.main.activity_user_data.*


class UserDataActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_user_data)

        val items = listOf("Мужской", "Женский")
        val adapter = ArrayAdapter(this, R.layout.list_item,R.id.list_item, items)
        (txtField_gender.editText as? AutoCompleteTextView)?.setAdapter(adapter)
    }
}