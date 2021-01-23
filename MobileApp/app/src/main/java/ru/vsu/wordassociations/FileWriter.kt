package ru.vsu.wordassociations

import android.content.Context
import java.io.FileOutputStream

 public class WordWriter {

     fun  write(dataList:ArrayList<String>, context: Context){
         var fileName = "Record" + dataList.get(6)+".txt"
         val data:String = dataList.get(1)
         val fileOutputStream: FileOutputStream
         try {
             fileOutputStream = context.openFileOutput(fileName, Context.MODE_PRIVATE)
             fileOutputStream.write(data.toByteArray())
         }catch (e: Exception){
             e.printStackTrace()
         }
     }

}