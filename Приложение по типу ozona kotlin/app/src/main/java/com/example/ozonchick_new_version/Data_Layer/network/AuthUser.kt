package com.example.ozonchick_new_version.Data_Layer.network

import android.util.Log
import com.example.ozonchick_new_version.Data_Layer.model.DTOMessage
import io.github.jan.supabase.createSupabaseClient
import io.github.jan.supabase.gotrue.Auth
import io.github.jan.supabase.gotrue.SessionSource
import io.github.jan.supabase.gotrue.SessionStatus
import io.github.jan.supabase.gotrue.auth
import io.github.jan.supabase.gotrue.providers.builtin.Email
import io.github.jan.supabase.postgrest.Postgrest
import kotlinx.coroutines.CompletableDeferred
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import java.lang.Exception

/**
 * Класс предназанчаен для регистрации пользователя
 * 24.03.2024
 *@param AuthEmail авторизация пользователя
 * @author Matvei
 *
 * */

class AuthUser() {
/*    private val supabase = createSupabaseClient(
        supabaseUrl = "https://qxniznftwaxnvnksitua.supabase.co",
        supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF4bml6bmZ0d2F4bnZua3NpdHVhIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDg4NDc1NTAsImV4cCI6MjAyNDQyMzU1MH0.7X_dAg3PvNrCsl14_N8z8YCfd0pxKWmV_dbNKczm_Lc"
    ) {
        install(Auth)
        install(Postgrest)
    }*/
    suspend fun AuthEmail(mail:String, passwordUser : String) : DTOMessage {
        var Info = CompletableDeferred<DTOMessage>()
        try {
            /*val user = supabase.auth.retrieveUserForCurrentSession(updateSession = true)*/
            CoroutineScope(Dispatchers.IO).launch {
                supabase.auth.signInWith(Email) {
                    email = mail
                    password = passwordUser
                }
                supabase.auth.sessionStatus.collect {
                    when (it) {
                        is SessionStatus.Authenticated -> {
                            println("Received new authenticated session.")
                            when (it.source) { //Check the source of the session
                                SessionSource.External -> Log.d("Сесия", "External")
                                is SessionSource.Refresh -> Log.d("Сесия", "Refresh")
                                is SessionSource.SignIn -> {
//                                emailUser.value = user.email.toString()
//                                /*Log.d("Имя",emailUser.value)*/
//                                ITSOKAY.value = true
                                   Info.complete(DTOMessage(true,"Успешная авторизация"))
                                }

                                is SessionSource.SignUp -> Info.complete(DTOMessage(true,"Успешный выход"))
                                SessionSource.Storage -> Log.d("Сесия", "Storage")
                                SessionSource.Unknown -> Log.d("Сесия", "Unknown")
                                is SessionSource.UserChanged -> Log.d("Сесия", "UserChanged")
                                is SessionSource.UserIdentitiesChanged -> Log.d("Сесия", "UserIdentitiesChanged")
                            }
                        }

                        SessionStatus.LoadingFromStorage -> println("Loading from storage")
                        SessionStatus.NetworkError ->  Info.complete(DTOMessage(true,"Нет соединение с сервером"))
                        is SessionStatus.NotAuthenticated -> {
                            if (it.isSignOut) {
                                println("User signed out")
                            } else {
                                println("User not signed in")
                            }
                        }

                    }
                }
            }
        }
        catch (e : Exception){
            Info.complete( DTOMessage(false,"Не коредные данные"))
        }
        return Info.await()
    }



    fun AuthGoogle(){

    }

}