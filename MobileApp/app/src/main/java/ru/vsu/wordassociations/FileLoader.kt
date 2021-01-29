package ru.vsu.wordassociations

import android.content.Context
import android.net.Uri
import java.io.*


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


        val path = context.getExternalFilesDir(null)
        val letDirectory = File(path, "Settings")
        var file :File
        letDirectory.mkdirs()
        if (option == 1) {
            file = File(letDirectory, "Settings.txt")
        } else {
            file = File(letDirectory, "instructions.txt")
        }


        val fis: FileInputStream
        try {

            fis = context.openFileInput(file.toString())

            val isr = InputStreamReader(fis)
            val bufferedReader = BufferedReader(isr)

            var line: String?
            while (bufferedReader.readLine().also { line = it } != null) {
                line?.let { arrayList.add(it) }
            }

        } catch (ex: Exception) {
            //ignored
        }
        arrayList.trimToSize()


        return arrayList
    }
}
