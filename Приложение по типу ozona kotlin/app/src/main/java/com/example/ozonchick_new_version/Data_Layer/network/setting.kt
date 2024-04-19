package com.example.ozonchick_new_version.Data_Layer.network

import io.github.jan.supabase.createSupabaseClient
import io.github.jan.supabase.gotrue.Auth
import io.github.jan.supabase.postgrest.Postgrest


    val supabase = createSupabaseClient(
        supabaseUrl = "https://qxniznftwaxnvnksitua.supabase.co",
        supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF4bml6bmZ0d2F4bnZua3NpdHVhIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDg4NDc1NTAsImV4cCI6MjAyNDQyMzU1MH0.7X_dAg3PvNrCsl14_N8z8YCfd0pxKWmV_dbNKczm_Lc"
    ) {
        install(Auth)
        install(Postgrest)
    }


