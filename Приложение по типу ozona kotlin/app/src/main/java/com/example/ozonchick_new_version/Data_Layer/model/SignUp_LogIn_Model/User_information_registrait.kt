package com.example.ozonchick_new_version.Data_Layer.model.SignUp_LogIn_Model

import kotlinx.serialization.Serializable

@Serializable
data class User_information_registrait(
    val name:String,
    val phone_number:String,
    val email:String,
)
