package ru.vsu.wordassociations

import android.content.Context
import android.net.Uri
import java.io.BufferedReader
import java.io.FileInputStream
import java.io.IOException
import java.io.InputStreamReader


class FileLoader {

    fun loadExternalFile(uri: Uri, context: Context): String {
        var reader: BufferedReader? = null
        val builder = StringBuilder()
        try {
            reader = BufferedReader(InputStreamReader(context.contentResolver.openInputStream(uri)))
            var line: String?
            while (reader.readLine().also { line = it } != null) {
                builder.append(line)
            }
        } catch (e: IOException) {
            //
        } finally {
            if (reader != null) {
                try {
                    reader.close()
                } catch (e: IOException) {
                  //
                }
            }
        }
        return builder.toString()

    }

    fun loadInternalFile(context: Context, option: Int): String {
        val sb = java.lang.StringBuilder()
        try {
            val fis: FileInputStream = if (option == 1) {
                context.openFileInput("instruction.txt")
            } else {
                context.openFileInput("settings.txt")
            }
            val isr = InputStreamReader(fis)
            val bufferedReader = BufferedReader(isr)

            var line: String?
            while (bufferedReader.readLine().also { line = it } != null) {
                sb.append(line)
            }

        } catch (ex: Exception) {
//ignored
        }

        return sb.toString()
    }
}