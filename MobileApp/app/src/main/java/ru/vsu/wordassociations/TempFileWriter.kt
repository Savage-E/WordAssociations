package ru.vsu.wordassociations

import android.R.attr.data
import android.content.Context
import java.io.File
import java.io.FileOutputStream
import java.util.*


class TempFileWriter {
    fun writeSettings(context: Context) {


        val fileName = "Settings.txt"


        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Settings")
        letDirectory.mkdirs()
        val file = File(letDirectory, fileName)
        val out = FileOutputStream(file, false)
        val str ="3 3\nдом\nквартира\nдача\n3 5\nкошка\nмышка\nкорм"
        val contents: ByteArray = str.toByteArray()
        out.write(contents)
        out.flush()
        out.close()


    }
}