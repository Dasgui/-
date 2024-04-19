package com.example.ozonchick_new_version.Screens.Home

import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.material3.Button
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import cafe.adriel.voyager.core.screen.Screen
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.BackColorBlue
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.BackColorGreen
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_Background
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_MainText
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Ozonchick_new_versionTheme

class Settings_Screen():Screen {
    @Composable
    override fun Content() {
        Surface(
            color = Color_Background.value,
            modifier = Modifier.fillMaxSize()
        ) {
            Settings_Screen_construct()
        }
    }
}

@Composable
fun Settings_Screen_construct()
{
    Column(
        modifier = Modifier.fillMaxWidth(),
        verticalArrangement = Arrangement.Center
    ) {
        Button(onClick = {
            Color_Background.value = Color.White
            Color_MainText.value = Color.Black
        }
        )
        {
            Text(text = "Белая схема")
        }
        Button(onClick = {
            Color_Background.value = Color.Black
            Color_MainText.value = Color.White
        }
        )
        {
            Text(text = "Белая схема")
        }
        Button(onClick = {
            Color_Background.value = Color.Yellow
            Color_MainText.value = Color.Black
        }
        )
        {
            Text(text = "Белая схема")
        }
        Button(onClick = {
            Color_Background.value = BackColorBlue
            Color_MainText.value = Color.Black
        }
        )
        {
            Text(text = "Белая схема")
        }
        Button(onClick = {
            Color_Background.value = BackColorGreen
            Color_MainText.value = Color.Black
        }
        )
        {
            Text(text = "Белая схема")
        }
    }
}