package ru.vsu.wordassociations

import android.content.Context
import android.net.Uri
import java.io.BufferedReader
import java.io.File
import java.io.IOException
import java.io.InputStreamReader


class FileLoader {

    fun loadFiles(uri: Uri, context: Context): ArrayList<String> {
        var reader: BufferedReader? = null
        val arrayList = ArrayList<String>()
        try {
            reader = BufferedReader(InputStreamReader(context.contentResolver.openInputStream(uri)))
            var line: String?
            while (reader.readLine().also { line = it } != null) {
                line?.let { arrayList.add(it) }
            }
        } catch (e: IOException) {
            //
        } finally {
            if (reader != null) {
                try {
                    reader.close()
                } catch (e: IOException) {
                    // ignored
                }
            }
        }
        return arrayList

    }

    fun loadSavedSettings(context: Context, option: Int): ArrayList<String> {
        val arrayList = ArrayList<String>()
        var reader: BufferedReader? = null
        val path = context.getExternalFilesDir(null)

        val letDirectory = File(path, "Settings")
        val file: File
        file = if (option == 1) {
            File(letDirectory, "instructions.txt")
        } else {
            File(letDirectory, "Settings.txt")
        }
        letDirectory.mkdirs()
        try {
            reader = BufferedReader(
                InputStreamReader(
                    context.contentResolver.openInputStream(
                        Uri.fromFile(file)
                    )
                )
            )
            var line: String?
            while (reader.readLine().also { line = it } != null) {
                line?.let { arrayList.add(it) }
            }
        } catch (e: IOException) {
            //
        } finally {
            if (reader != null) {
                try {
                    reader.close()
                } catch (e: IOException) {
                    // ignored
                }
            }
        }

        arrayList.trimToSize()


        return arrayList
    }
}
