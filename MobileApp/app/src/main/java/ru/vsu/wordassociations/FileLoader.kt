package ru.vsu.wordassociations

import android.content.Context
import android.net.Uri
import java.io.BufferedReader
import java.io.IOException
import java.io.InputStreamReader


class FileLoader {

    fun loadFile(uri: Uri, context: Context): String {
        var result = String()
        var reader: BufferedReader? = null
        val builder = StringBuilder()
        try {
            reader = BufferedReader(InputStreamReader(context.getContentResolver().openInputStream(uri)))
            var line: String? = ""
            while (reader.readLine().also { line = it } != null) {
                builder.append(line)
            }
        } catch (e: IOException) {
            e.printStackTrace()
        } finally {
            if (reader != null) {
                try {
                    reader.close()
                } catch (e: IOException) {
                    e.printStackTrace()
                }
            }
        }
        return builder.toString()

    }
}