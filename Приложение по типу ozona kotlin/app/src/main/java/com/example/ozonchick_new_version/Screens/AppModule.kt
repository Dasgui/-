package com.example.ozonchick_new_version.Screens

import com.example.ozonchick_new_version.Presentation_Layer.Models.Home_ViewModel
import com.example.ozonchick_new_version.Presentation_Layer.Models.Send_a_Package_ViewModel
import com.example.ozonchick_new_version.Presentation_Layer.Models.SignUp_ViewModel
import org.koin.dsl.module

var AppModule = module {
    single {
        SignUp_ViewModel()

    }
    single {
        Home_ViewModel()
    }
    single {
        Send_a_Package_ViewModel()
    }
}