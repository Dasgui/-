package com.example.ozonchick_new_version.Domain

import android.content.Context
import android.view.Gravity
import android.widget.Toast
import com.example.ozonchick_new_version.Data_Layer.network.AuthUser
import com.example.ozonchick_new_version.Data_Layer.network.RegistraitUser
import kotlinx.coroutines.CompletableDeferred

class postRegistrait(context:Context) {
    val context = context
    suspend fun postRegistraitEmail(name:String,phone:String,mail:String,password:String):Boolean{
        var accessRegistrait = CompletableDeferred<Boolean>()
        var responseRegistrait = RegistraitUser().RegisstraitEmail(name,phone,mail,password)
        accessRegistrait.complete(responseRegistrait.acess)
        accessRegistrait.await()
        if (responseRegistrait.acess){
            val toast = Toast.makeText(context,responseRegistrait.message, Toast.LENGTH_LONG)
            toast.setGravity(Gravity.FILL_VERTICAL,0,0)
            toast.show()
            return true
        }
        else{
            val toast = Toast.makeText(context,responseRegistrait.message, Toast.LENGTH_LONG)
            toast.setGravity(Gravity.FILL_VERTICAL,0,0)
            toast.show()
            return false
        }
    }
}
