package com.example.ozonchick_new_version.Presentation_Layer.Models

import android.content.Context
import android.util.Log
import androidx.compose.runtime.MutableState
import androidx.compose.runtime.mutableStateOf
import androidx.compose.ui.platform.LocalContext
import androidx.lifecycle.ViewModel
import cafe.adriel.voyager.navigator.LocalNavigator
import com.example.ozonchick_new_version.Data_Layer.data.db.userAuthInformation
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.UserAuth
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.User_id_name_email
import com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model.User_name_email
import com.example.ozonchick_new_version.Data_Layer.network.supabase
import com.example.ozonchick_new_version.Domain.postAuth
import com.example.ozonchick_new_version.Domain.postRegistrait
import com.google.gson.Gson
import io.github.jan.supabase.postgrest.from
import io.github.jan.supabase.postgrest.query.Columns
import io.paperdb.Paper
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking
import kotlinx.serialization.Serializable
import org.koin.androidx.compose.koinViewModel

class SignUp_ViewModel() : ViewModel() {
    var idUser: MutableState<Int> = mutableStateOf(0)
    var nameUser: MutableState<String> = mutableStateOf("")
    var phoneNumber: MutableState<String> = mutableStateOf("")
    var emailUser: MutableState<String> = mutableStateOf("")
    var passwordUser: MutableState<String> = mutableStateOf("")
    var confirmPassword: MutableState<String> = mutableStateOf("")
    var userBalance:MutableState<Float> = mutableStateOf(0f)

    var isDarkMode: MutableState<Boolean> = mutableStateOf(false)

    var ITSOKAY:MutableState<Boolean> = mutableStateOf(false)


    val accessAuth = MutableStateFlow(false)
    val accessRegistrait = MutableStateFlow(false)
    var rememberUser:MutableState<Boolean> = mutableStateOf(false)

    val navigator = LocalNavigator

/*    val supabase = createSupabaseClient(
        supabaseUrl = "https://qxniznftwaxnvnksitua.supabase.co",
        supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF4bml6bmZ0d2F4bnZua3NpdHVhIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDg4NDc1NTAsImV4cCI6MjAyNDQyMzU1MH0.7X_dAg3PvNrCsl14_N8z8YCfd0pxKWmV_dbNKczm_Lc"
    ) {
        install(Auth)
        install(Postgrest)
    }*/


    fun Auth(contextAuth:Context)
    {
//        CoroutineScope(Dispatchers.IO).launch {
//            val user = supabase.auth.retrieveUserForCurrentSession(updateSession = true)
//            try {
//                supabase.auth.signInWith(Email) {
//                    email = emailUser.value
//                    password = passwordUser.value
//                }
//
//                supabase.auth.sessionStatus.collect {
//                    when(it) {
//                        is SessionStatus.Authenticated -> {
//                            println("Received new authenticated session.")
//                            when(it.source) { //Check the source of the session
//                                SessionSource.External -> Log.d("Сесия", "External")
//                                is SessionSource.Refresh -> Log.d("Сесия", "Refresh")
//                                is SessionSource.SignIn -> {
//                                    Log.d("Сесия", "Зашёл")
//                                    emailUser.value = user.email.toString()
//                                    /*Log.d("Имя",emailUser.value)*/
//                                    ITSOKAY.value = true
//                                }
//                                is SessionSource.SignUp -> Log.d("Сесия", "Авторизовался")
//                                SessionSource.Storage -> TODO()
//                                SessionSource.Unknown -> TODO()
//                                is SessionSource.UserChanged -> TODO()
//                                is SessionSource.UserIdentitiesChanged -> TODO()
//                            }
//                        }
//                        SessionStatus.LoadingFromStorage -> println("Loading from storage")
//                        SessionStatus.NetworkError -> println("Network error")
//                        is SessionStatus.NotAuthenticated -> {
//                            if(it.isSignOut) {
//                                println("User signed out")
//                            } else {
//                                println("User not signed in")
//                            }
//                        }
//
//                    }
//                }
//            }
//            catch (e:Exception)
//            {
//                Log.d("Сесия", e.toString())
//            }
//        }

//    try {
//

/*        viewModelScope.launch {
            Log.d("Вход", "Попал в блок")
            var responseAuth: Boolean
            runBlocking {

                responseAuth = postAuth(contextAuth).postAuthEmail(emailUser.value, passwordUser.value)
            }
            accessAuth.value = responseAuth
        }*/
        var responseAuth: Boolean
        runBlocking {

            responseAuth = postAuth(contextAuth).postAuthEmail(emailUser.value, passwordUser.value)
        }
        accessAuth.value = responseAuth
        if(rememberUser.value)
        {
            userAuthInformation.add(UserAuth(emailUser.value, passwordUser.value))
            Paper.book().write("User", userAuthInformation)
            Paper.book().write("DarkTheme", isDarkMode)
        }
        else
        {
            emailUser.value = emailUser.value
        }
//    }
//    catch (e:Exception){
//
//    }

    }





    fun Registrait(context: Context)
    {
/*        viewModelScope.launch {
            var responseRegistrait: Boolean
            runBlocking {
                responseRegistrait = postRegistrait(context).postRegistraitEmail(nameUser.value,phoneNumber.value,emailUser.value,passwordUser.value)
            }
            accessRegistrait.value = responseRegistrait
        }*/
        var responseRegistrait: Boolean
        runBlocking {
            responseRegistrait = postRegistrait(context).postRegistraitEmail(nameUser.value,phoneNumber.value,emailUser.value,passwordUser.value)
        }
        accessRegistrait.value = responseRegistrait

    }
    /*        viewModelScope.launch {
            var response: Boolean
            runBlocking {
                *//*response*//*
            }
        }
        CoroutineScope(Dispatchers.IO).launch {
            var user = supabase.auth.signUpWith(provider = Email)
            {
                email = emailUser.value
                password = passwordUser.value
                data = buildJsonObject {
                    put("nameUser", nameUser.value)
                    put("phoneNumber", phoneNumber.value)
                }
            }

            supabase.from("user_information").insert(User_Information_Registrait(nameUser.value,phoneNumber.value,emailUser.value))
        }*/

    fun Name_for_base():String
    {
        CoroutineScope(Dispatchers.IO).launch {
            val result = supabase.from("user_information").select(){
                filter {
                    User_name_email::email eq emailUser.value
                }
            }
            val note = Gson().fromJson(result.data, Array<User_id_name_email>::class.java)
            Log.d("База", note[0].name)
            Log.d("База id", note[0].user_id.toString())
            nameUser.value=note[0].name
        }
        return nameUser.value
    }

/*    fun Balance_for_base():Float
    {
        CoroutineScope(Dispatchers.IO).launch {
            val result = supabase.from("user_information").select(){
                filter {
                    User_name_email::email eq emailUser.value
                }
            }
            val note = Gson().fromJson(result.data, Array<user_Name>::class.java)
            Log.d("База", note[0].user_id.toString())
            val result_id = supabase.from("user_balance").select(){
                filter {
                    user_Balance::user_id eq note[0].user_id
                }
            }
            val note_id = Gson().fromJson(result_id.data, Array<user_Balance>::class.java)
//            Log.d("id с базы", note_id[0].balance.toString())
            userBalance.value = note_id[0].balance
        }
        return userBalance.value
    }*/

    var EnableCheck: MutableState<Boolean> = mutableStateOf(false)
    fun ClearParametres()
    {
        var Peremens = arrayListOf(nameUser.value, phoneNumber.value, emailUser.value, passwordUser.value, confirmPassword.value)
        Log.d("Проверка очистки", Peremens.toString())
        for (i in 0 until Peremens.size)
        {
            Peremens[i] = ""
        }
        Log.d("Проверка очистки", Peremens.toString())
    }

    fun ConstructProverka(firstLine:String, secondLine:String = ""):Boolean
    {
        if(firstLine.isNotEmpty() && secondLine.isNotEmpty())
        {
            return true
        }
        else if (firstLine.isNotEmpty() && secondLine == null)
        {
            return true
        }
        return false
    }

    fun Proverka(): Boolean {
        if (nameUser.value.isNotEmpty() && phoneNumber.value.isNotEmpty()
            && emailUser.value.isNotEmpty() && passwordUser.value.isNotEmpty()
            && EnableCheck.value && confirmPassword.value.isNotEmpty()
            && ProverkaMail() && passwordUser.value == confirmPassword.value) {
            return true
        }
        return false
    }

    fun ProverkaMail(): Boolean {
        return emailUser.value == emailUser.value.toLowerCase()
        /*        Email.value.trimMargin().forEach { i ->
                    if (i.toString() == "F")
                    {
                        return true
                    }
                }
                return false*/
    }
    /*    fun NextScreen(provider: ScreenProvider)
        {
            val screen = rememberScreen(provider = provider)
            navigator.current?.push(screen)
        }*/
}

/*@Serializable
data class user_id_email(
    val id:Int,
    val email:String,
)*/


/*@Serializable
data class user_Name(
    val user_id:Int,
    val name:String,
    val email:String,
)*/


/*@Serializable
data class user_Balance(
    val user_id:Int,
    val email: String,
    val balance:Float,
)*/


