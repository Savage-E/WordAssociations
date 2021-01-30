package ru.vsu.wordassociations

import android.content.Context
import android.os.Build
import androidx.annotation.RequiresApi
import com.opencsv.CSVWriter
import java.io.File
import java.io.FileOutputStream
import java.io.FileWriter
import java.io.IOException
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter
import java.util.*


class MyFileWriter {

    @RequiresApi(Build.VERSION_CODES.O)
    fun writeRecord(
        dataList: ArrayList<String>, associations:
        Array<Array<String>>, settings: ArrayList<String>, context: Context
    ) {
        //Форматируем тукущую дату в файловый формат.
        val date = LocalDateTime.now()
        val formatter = DateTimeFormatter.ofPattern("dd.MM.yyyy HH.mm.ss")
        val formattedDate = date.format(formatter)
        val fileName =
            dataList[1] + " " + dataList[0][0] + " " + dataList[2][0] + " " + formattedDate + ".txt"

        //Создаем нужную директорию.
        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Records")
        letDirectory.mkdirs()
        val file = File(letDirectory, fileName)

/*
        val data: MutableList<Array<String>> = ArrayList()
        data.add(arrayOf(dataList[1]+ " " +dataList[0]+ " " +dataList[2]+ " " +dataList[3]+ " " +dataList[4]))
        val temp = null
        temp?.let { settings.toCollection(it) }


        temp?.let { data.addAll(1, it) }
        for (array in associations)
        {
            data.add(array)

        }

        var writer: CSVWriter? = null
        try {
            writer = CSVWriter(FileWriter(file))



            writer.writeAll(data) // data is adding to csv
            writer.close()

        } catch (e: IOException) {
            e.printStackTrace()
        }*/


        //Далее пишем в файл наши данные
         file.appendText(dataList[1] + " ", Charsets.UTF_8)
         file.appendText(dataList[0] + " ", Charsets.UTF_8)
         file.appendText(dataList[2] + " ", Charsets.UTF_8)
         file.appendText(dataList[3] + " ", Charsets.UTF_8)
         file.appendText(dataList[4] + " ", Charsets.UTF_8)
         file.appendText("\n", Charsets.UTF_8)
         for (i in 0 until settings.size) {
             file.appendText(settings[i] + ";", Charsets.UTF_8)
         }
         file.appendText("\n", Charsets.UTF_8)

         for (i in associations) {
             for (j in i) {
                 file.appendText("$j;", Charsets.UTF_8)
             }
             file.appendText("\n", Charsets.UTF_8 )
         }

    }

    //Функция для сохранения настроек и инструкции.
    fun writeSettings(
        settings: ArrayList<String>,
        instructions: ArrayList<String>,
        context: Context
    ) {
        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Settings")
        letDirectory.mkdirs()
        var file = File(letDirectory, "settings.txt")
        var out = FileOutputStream(file, false)
        settings.forEach {
            out.write((it + "\n").toByteArray())

        }
        out.flush()
        out.close()
        file = File(letDirectory, "instructions.txt")
        out = FileOutputStream(file, false)
        instructions.forEach {
            out.write((it + "\n").toByteArray())

        }
        out.flush()
        out.close()
    }
}
