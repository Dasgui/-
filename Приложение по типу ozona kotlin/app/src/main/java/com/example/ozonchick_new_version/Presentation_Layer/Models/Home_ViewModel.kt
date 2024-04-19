package com.example.ozonchick_new_version.Presentation_Layer.Models

import android.util.Log
import androidx.compose.runtime.MutableState
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.ViewModel
import com.example.ozonchick_new_version.Data_Layer.data.db.emailSharedUser
import com.example.ozonchick_new_version.Data_Layer.data.db.userAuthInformation
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.UserAuth
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.User_balance
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.User_id_name_email
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.User_name_email
import com.example.ozonchick_new_version.Data_Layer.network.supabase
import com.google.gson.Gson
import io.github.jan.supabase.postgrest.from
import io.github.jan.supabase.postgrest.query.Columns
import io.paperdb.Paper
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch

class Home_ViewModel() : ViewModel() {
    var idUser: MutableState<Int> = mutableStateOf(0)
    var nameUser: MutableState<String> = mutableStateOf("")
    var emailUser: MutableState<String> =
        if (emailSharedUser.value.isNotEmpty()) {
            mutableStateOf(emailSharedUser.value)
        } else {
            mutableStateOf(userAuthInformation[0].email)
        }
    var userBalance: MutableState<Int> = mutableStateOf(0)

    fun Name_for_base(): String {
        CoroutineScope(Dispatchers.IO).launch {
            val result =
                supabase.from("user_information").select(columns = Columns.list("name", "email")) {
                    filter {
                        User_name_email::email eq emailUser.value
                    }
                }
            val note = Gson().fromJson(result.data, Array<User_id_name_email>::class.java)
            nameUser.value = note[0].name
        }
        return nameUser.value
    }

/*    fun GetId(): Int {
        CoroutineScope(Dispatchers.IO).launch {
            val take_id = supabase.from("user_information").select(Columns.list("user_id", "email"))
            {
                filter {
                    user_id_email::email eq emailUser.value
                }
            }
            val note = Gson().fromJson(take_id.data, Array<user_Name>::class.java)
            idUser.value = note[0].user_id
        }
        return idUser.value
    }*/


    fun Balance_for_base(): Int {
        CoroutineScope(Dispatchers.IO).launch {
            val result =
                supabase.from("user_information").select(Columns.list("user_id", "email")) {
                    filter {
                        User_name_email::email eq emailUser.value
                    }
                }
            val note = Gson().fromJson(result.data, Array<User_id_name_email>::class.java)
            Log.d("База", note[0].user_id.toString())
            val result_id = supabase.from("user_balance").select() {
                filter {
                    User_balance::user_id eq note[0].user_id
                }
            }
            val note_id = Gson().fromJson(result_id.data, Array<User_balance>::class.java)
            Log.d("id с базы", note_id[0].balance.toString())
            userBalance.value = note_id[0].balance
        }
        return userBalance.value
    }
}