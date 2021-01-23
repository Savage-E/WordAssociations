package ru.vsu.wordassociations

import android.content.Context
import android.os.Environment
import java.io.File
import java.io.FileOutputStream


public class WordWriter {

    fun write(dataList: ArrayList<String>, context: Context) {


          var fileName = "Record" + dataList.get(6) + ".txt"
          val data: String = dataList.get(1)
        val folder_main = "Records"

        val f = File(Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS), folder_main)
        if (!f.exists()) {
            f.mkdirs()
        }


       /* val name = "suresh"
        val folder: File =
            Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS)*/
        val myFile = File(f, fileName)
        val fstream = FileOutputStream(myFile)
        fstream.write(data.toByteArray())
        fstream.close()


        /*val fileOutputStream: FileOutputStream
        try {
            fileOutputStream = context.openFileOutput(fileName, Context.MODE_PRIVATE)
            fileOutputStream.write(data.toByteArray())
            fileOutputStream.close()


        } catch (e: Exception) {
            e.printStackTrace()
        }*/

    }

}