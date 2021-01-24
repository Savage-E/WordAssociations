package ru.vsu.wordassociations

import android.content.Context
import android.os.Environment
import java.io.File
import java.io.FileOutputStream
import java.util.*
import kotlin.collections.ArrayList


public class WordWriter {

    fun write(dataList: ArrayList<String>, context: Context) {
        val uniqueString: String = UUID.randomUUID().toString()
        var fileName = ""
        if (dataList.get(6).equals("Цепочка ассоциаций")) {
            fileName = "Record" + "_chain" + "_" + uniqueString + ".txt"
        } else {
            fileName = "Record" + "_single" + "_" + uniqueString + ".txt"

        }

        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Records")
        letDirectory.mkdirs()
        val file = File(letDirectory, fileName)


        file.appendText(dataList.get(0) + " ")
        file.appendText(dataList.get(1) + " ")
        file.appendText(dataList.get(2) + " ")
        file.appendText(dataList.get(3) + " ")
        file.appendText(dataList.get(5) + " ")
        file.appendText(dataList.get(4) + " ")

        for (i in 7..dataList.size) {
            file.appendText("\n" + dataList.get(i))
        }

    }

}