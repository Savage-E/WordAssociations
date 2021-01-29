package ru.vsu.wordassociations

import android.app.AlertDialog
import android.content.Intent
import android.os.Build
import android.os.Bundle
import android.widget.Toast
import androidx.annotation.RequiresApi
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_test.*


class TestActivity : AppCompatActivity() {
    private var settings = ArrayList<String>()
    private var instructions = ArrayList<String>()
    private var dataList = ArrayList<String>()
    private var option = String()
    private var chainNumber = 0
    private var count = 0
    private var amount = 0
    private var currentIndex = 0
    private var ind = 0
    private var associations = arrayOf<Array<String>>()

    @RequiresApi(Build.VERSION_CODES.O)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_test)
        val intent = intent
        option = intent.getStringExtra("option").toString()
        instructions = intent.getStringArrayListExtra("instructions") as ArrayList<String>
        dataList = intent.getStringArrayListExtra("dataList") as ArrayList<String>
        settings = intent.getStringArrayListExtra("settings") as ArrayList<String>

        initializeValues()

        btn_submit_word.setOnClickListener()
        {

            if (et_word.text.toString() == "") {
                Toast.makeText(this, "Введите ассоциацию!", Toast.LENGTH_LONG).show()
            } else {

                associations[count - 1][currentIndex - 1] = et_word.text.toString()
                count++
                if (count > amount) {
                    txtField_word_count.text =
                        "Cлово " + (count - 1).toString() + " из " + amount.toString() + " Цепочка " + currentIndex.toString() + " из " + chainNumber.toString()
                    et_word.isEnabled = false
                    btn_finish.isEnabled = true
                    btn_submit_word.isEnabled = false
                    btn_finish.text = "Заверишить " + currentIndex++.toString() + " цепочку"
                } else {
                    txtField_word_count.text =
                        "Cлово $count из $amount Цепочка $currentIndex из $chainNumber"
                    if (option == "Цепочка ассоциаций") {
                        txtField_word.text = et_word.text
                    }
                }

                et_word.text?.clear()
            }
        }

        btn_finish.setOnClickListener {
            if (currentIndex - 1 == chainNumber) {
                val builder = AlertDialog.Builder(this)
                builder.setTitle("Внимание!")
                builder.setMessage("Тестирование завершено! Спасибо!")
                //            var tempArray: Array<String> = Array(chainNumber + 1) { "" }

                builder.setPositiveButton(android.R.string.yes) { dialog, which ->
                    saveData()
                    finish()
                }
                builder.setNeutralButton("Начать заново") { dialog, which ->

                    val intent = Intent(this, MainActivity::class.java)
                    saveData()
                    startActivity(intent)
                    finish()
                }
                builder.show()
            } else {
                nextWord()
                txtField_word_count.text =
                    "Cлово $count из $amount Цепочка $currentIndex из $chainNumber"
            }


        }

    }

    //Функция для перехода на следующее базовое слово.
    private fun nextWord() {
        et_word.isEnabled = true
        btn_submit_word.isEnabled = true
        btn_finish.isEnabled = false
        if (option == "Звезда") {
            txtField_word.text = settings[currentIndex]
        } else {
            txtField_word.text = settings[currentIndex + ind]
        }
        count = 1

    }
    //Cохраняем настройки и инструкцию.
    @RequiresApi(Build.VERSION_CODES.O)
    private fun saveData() {
        val tempArray = ArrayList<String>()
        val fileWriter = MyFileWriter()
        if (option == "Звезда") {
            for (i in 1 until chainNumber + 1) {
                tempArray.add(settings[ind + i])
            }

        } else {
            for (i in 1 until chainNumber + 1) {
                tempArray.add(settings[i])
            }
        }
        fileWriter.writeRecord(
            dataList,
            associations,
            tempArray,
            applicationContext
        )
        fileWriter.writeSettings(settings,instructions,applicationContext)
    }


    private fun initializeValues() {
        //Инициализиурем поле с инструкцией.
        var str = String()
        for (i in instructions) {
            str += i
        }
        txtField_instruction.text = str
        //Инициализируем значения: количество цепочек, количество слов для цепочек, текущий индекс.
        if (option == "Цепочка ассоциаций") {
            chainNumber = settings[0].split(' ')[0].toInt()
            amount = settings[0].split(' ')[1].toInt()
            currentIndex = 1
            txtField_word.text = settings[currentIndex]

        } else {
            if (option == "Звезда") {
                ind = settings[0].split(' ')[0].toInt() + 1
                chainNumber = settings[ind].split(' ')[0].toInt()
                amount = settings[ind].split(' ')[1].toInt()
                currentIndex = 1
                txtField_word.text = settings[ind + currentIndex]
            }
        }
        count = 1
        //Инициализируем двумерый массив ассоциаций.
        for (i in 0 until amount) {
            var array = arrayOf<String>()
            for (j in 0 until chainNumber) {
                array += ""
            }
            associations += array
        }
        txtField_word_count.text =
            "Cлово $count из $amount Цепочка $currentIndex из $chainNumber"

        btn_finish.isEnabled = false
    }
    //Деактивируем кнопку назад.
    override fun onBackPressed() {
        super.onBackPressed()
        //Отключение кнопки назад.
    }
}




