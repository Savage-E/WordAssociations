package ru.vsu.wordassociations

import android.content.Context
import android.os.Build
import androidx.annotation.RequiresApi
import java.io.File
import java.io.FileOutputStream
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
            dataList[1] + " " + dataList[0][0] + " " + dataList[2][0] + " " + formattedDate + ".csv"

        //Создаем нужную директорию.
        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Records")
        letDirectory.mkdirs()
        val file = File(letDirectory, fileName)

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
            file.appendText("\n", Charsets.UTF_8)
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
