package com.example.ozonchick_new_version.Screens.Home

import android.annotation.SuppressLint
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.BottomAppBar
import androidx.compose.material3.Button
import androidx.compose.material3.Card
import androidx.compose.material3.CardDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.MutableState
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.unit.dp
import cafe.adriel.voyager.core.screen.Screen
import com.example.ozonchick_new_version.Data_Layer.data.ui.text_tema.Tema
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.BackColorBlue
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.BackColorGreen
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_Background
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_MainText
import com.example.ozonchick_new_version.R

private var bottomTextStyle: androidx.compose.ui.text.TextStyle = Tema.Text_14_14_Regular
private var bottomTextColor: MutableState<Color> = Color_MainText
private var background :MutableState<Color> = Color_Background

class Spisok_Predlogenii_Screen() : Screen {
    @Composable
    override fun Content() {
        Surface(
            modifier = Modifier.fillMaxSize(),
            color = Color_Background.value
        ) {
            Spisok_Predlogenii_construct()
        }
    }
}


@OptIn(ExperimentalMaterial3Api::class)
@SuppressLint("UnusedMaterial3ScaffoldPaddingParameter")
@Composable
fun Spisok_Predlogenii_construct() {
    Scaffold(
        topBar = {
            Card(
                elevation = CardDefaults.cardElevation(10.dp),
                shape = RoundedCornerShape(0.dp),
            ) {
                TopAppBar(
                    title = {
                    },
                    colors = TopAppBarDefaults.topAppBarColors(containerColor = background.value),
                    modifier = Modifier
                        .fillMaxWidth(),
                )
            }
        },
        bottomBar = {
            BottomAppBar(
                containerColor = background.value
            ) {
                Row(
                    modifier = Modifier.fillMaxWidth(),
                    horizontalArrangement = Arrangement.SpaceAround
                ) {
                    Column(
                        verticalArrangement = Arrangement.Center,
                        horizontalAlignment = Alignment.CenterHorizontally,
                        modifier = Modifier.clickable { }
                    ) {
                        Icon(
                            painter = painterResource(id = R.drawable.house_2),
                            contentDescription = "Домашняя страница",
                            modifier = Modifier
                                .size(45.dp),
                            tint = bottomTextColor.value
                        )
                        Text(
                            text = "Spisok",
                            style = bottomTextStyle,
                            color = bottomTextColor.value,
                            modifier = Modifier.padding(top = 3.dp)
                        )
                    }
                    Column(
                        verticalArrangement = Arrangement.Center,
                        horizontalAlignment = Alignment.CenterHorizontally,
                        modifier = Modifier.clickable { /*navigator?.push(screen) */ }
                    )
                    {
                        Icon(
                            painter = painterResource(id = R.drawable.profile_circle),
                            contentDescription = "Домашняя страница",
                            modifier = Modifier
                                .size(45.dp),
                            tint = bottomTextColor.value
                        )
                        Text(
                            text = "Profile",
                            style = bottomTextStyle,
                            color = bottomTextColor.value,
                            modifier = Modifier.padding(top = 3.dp)
                        )
                    }
                }
            }
        },
    ) {
        Column(
            modifier = Modifier
                .padding(top = 100.dp)
                .fillMaxWidth(),
            verticalArrangement = Arrangement.Center,
            horizontalAlignment = Alignment.CenterHorizontally
        ) {

        }

    }
}

@Composable
fun Card_Vakans() {
    Column(

    ) {

    }
}