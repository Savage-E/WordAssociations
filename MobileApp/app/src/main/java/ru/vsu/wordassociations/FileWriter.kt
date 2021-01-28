package ru.vsu.wordassociations

import android.content.Context
import java.io.File
import java.util.*


public class WordWriter {

    fun write(dataList: ArrayList<String>, context: Context) {


        var fileName = "Record "  + Date().time.toString() + ".txt"


        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Records")
        letDirectory.mkdirs()
        val file = File(letDirectory, fileName)


        file.appendText(dataList[0] + " ")
        file.appendText(dataList[1] + " ")
        file.appendText(dataList[2] + " ")
        file.appendText(dataList[3] + " ")
        file.appendText(dataList[5] + " ")
        file.appendText(dataList[4] + " ")

        for (i in 7 until dataList.size) {
            file.appendText("\n" + dataList[i])
        }

    }

}