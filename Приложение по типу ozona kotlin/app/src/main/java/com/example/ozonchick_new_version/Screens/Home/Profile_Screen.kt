package com.example.ozonchick_new_version.Screens.Home

import android.annotation.SuppressLint
import android.util.Log
import androidx.compose.foundation.BorderStroke
import androidx.compose.foundation.Image
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.shape.CircleShape
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.BottomAppBar
import androidx.compose.material3.Card
import androidx.compose.material3.CardDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Icon
import androidx.compose.material3.IconButton
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Surface
import androidx.compose.material3.Text
import androidx.compose.material3.TopAppBar
import androidx.compose.material3.TopAppBarDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.MutableState
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.draw.clip
import androidx.compose.ui.draw.drawBehind
import androidx.compose.ui.geometry.Offset
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.graphics.ColorFilter
import androidx.compose.ui.graphics.RectangleShape
import androidx.compose.ui.graphics.Shape
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.unit.dp
import cafe.adriel.voyager.core.registry.rememberScreen
import cafe.adriel.voyager.core.screen.Screen
import cafe.adriel.voyager.navigator.LocalNavigator
import cafe.adriel.voyager.navigator.Navigator
import com.example.ozonchick_new_version.Data_Layer.data.ui.components.Public_Card
import com.example.ozonchick_new_version.Data_Layer.data.ui.text_tema.Tema
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_Background
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_MainText
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Ozonchick_new_versionTheme
import com.example.ozonchick_new_version.Presentation_Layer.Models.Home_ViewModel
import com.example.ozonchick_new_version.Presentation_Layer.Models.SignUp_ViewModel
import com.example.ozonchick_new_version.R
import com.example.ozonchick_new_version.Screens.Onboarding.Onboarding_Screen_1
import com.example.ozonchick_new_version.Screens.navigation.screen_provider.Send_a_Package_Provider
import org.koin.androidx.compose.koinViewModel


private var mainTextStyle: TextStyle = Tema.Text_16_16_Medium
private var secondTextStyle: TextStyle = Tema.Text_14_14_Regular

private var MenuTextColor: MutableState<Color> = Color_MainText

private var background: MutableState<Color> = Color_Background
private var mainTextColor: MutableState<Color> = Color_MainText

private var bottomTextStyle: androidx.compose.ui.text.TextStyle = Tema.Text_14_14_Regular
private var bottomTextColor: MutableState<Color> = Color_MainText

class Profile_Screen() : Screen {
    @Composable
    override fun Content() {
        Profile_Construct()
    }
}

@OptIn(ExperimentalMaterial3Api::class)
@SuppressLint("UnusedMaterial3ScaffoldPaddingParameter")
@Composable
fun Profile_Construct(vm: Home_ViewModel = koinViewModel()) {
    val screen = rememberScreen(provider = Send_a_Package_Provider.Send_a_Package)
    var navigator = LocalNavigator.current
    Scaffold(
        topBar = {
            Card(
                modifier = Modifier
                    .fillMaxWidth()
                    .drawBehind {
                        drawLine(
                            mainTextColor.value,
                            Offset(0f, size.height),
                            Offset(size.width, size.height),
                            5f
                        )
                    },
                shape = RectangleShape
            ) {
                TopAppBar(
                    title = {
                        Row(
                            modifier = Modifier.fillMaxSize(),
                            horizontalArrangement = Arrangement.Center,
                            verticalAlignment = Alignment.CenterVertically
                        ) {
                            Text(
                                text = "Профиль",
                                style = Tema.Text_16_16_Medium,
                                color = MenuTextColor.value,
                            )
                        }
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
        containerColor = background.value
    ) {

        Column(
            modifier = Modifier
                .fillMaxWidth()
                .padding(start = 24.dp, end = 24.dp, top = 90.dp)
        ) {
            Row(modifier = Modifier.fillMaxWidth()) {
                Image(
                    painter = painterResource(id = R.drawable.good_tick),
                    contentDescription = "К",
                    contentScale = ContentScale.Crop,
                    modifier = Modifier
                        .size(50.dp)
                        .clip(CircleShape)
                )
                Row(
                    modifier = Modifier
                        .fillMaxWidth()
                        .padding(top = 5.dp), horizontalArrangement = Arrangement.Center
                ) {
                    Column(
                        horizontalAlignment = Alignment.Start,
                        modifier = Modifier.padding(start = 10.dp)
                    ) {
                        Log.d("Имя 2", vm.nameUser.value)
                        Text(
                            text = vm.Name_for_base()/*vm.Name_for_base()*/,
                            style = Tema.MainText_16_30_500/*vm.Name_for_base()*/,
                            color = MaterialTheme.colorScheme.onPrimary
                        )
                        Text(
                            text = "Current balance ${vm.Balance_for_base()}",
                            style = Tema.SecondText_12_16_400/*vm.Balance_for_base().toString()*/,
                            color = MaterialTheme.colorScheme.onPrimary
                        )
                    }
                    Column(
                        horizontalAlignment = Alignment.End,
                        modifier = Modifier.fillMaxWidth()
                    ) {
/*                            Image(
                                painter = painterResource(id = R.drawable.eye_slash),
                                contentDescription = "Показ Вкл/Выкл",
                                contentScale = ContentScale.Crop,
                                modifier = Modifier
                                    .size(20.dp),
                                alignment = Alignment.CenterEnd,
                            )*/
//                            Icon(painter = painterResource(id = R.drawable.eye_slash), contentDescription = "D", tint = MaterialTheme.colorScheme.onPrimary, modifier = Modifier
//                                .size(20.dp).clickable {  }, )
                        IconButton(onClick = { /*TODO*/ }) {
                            Image(
                                painter = painterResource(id = R.drawable.eye_slash),
                                contentDescription = "Показ Вкл/Выкл",
                                contentScale = ContentScale.Crop,
                                modifier = Modifier
                                    .size(20.dp),
                                alignment = Alignment.CenterEnd,
                                colorFilter = ColorFilter.tint(MaterialTheme.colorScheme.onPrimary)
                            )
                        }
                    }
                }
            }
            Card_construct(
                "Настройки",
                "Здесь вы можете настроить приложение",
                R.drawable.setting_icon,
                navigator
            )
        }
    }


}

@Composable
private fun Card_construct(
    mainText: String,
    secondText: String,
    icon: Int,
    localNavigator: Navigator?
) {
    Public_Card(
        modifier = Modifier
            .fillMaxWidth()
            .height(60.dp)
            .clickable { localNavigator?.push(Settings_Screen()) },
    ) {
        Row(
            modifier = Modifier.fillMaxSize(),
            horizontalArrangement = Arrangement.SpaceAround,
            verticalAlignment = Alignment.CenterVertically
        ) {
            Row(
                verticalAlignment = Alignment.CenterVertically,
                horizontalArrangement = Arrangement.SpaceAround
            ) {
                Icon(
                    modifier = Modifier.size(20.dp),
                    painter = painterResource(id = icon),
                    contentDescription = "Настройки",
                    tint = mainTextColor.value
                )
                Column(
                    horizontalAlignment = Alignment.Start,
                    verticalArrangement = Arrangement.SpaceAround,
                    modifier = Modifier.padding(start = 5.dp)
                ) {
                    Text(
                        text = mainText,
                        style = mainTextStyle,
                        color = mainTextColor.value,
                    )
                    Text(
                        text = secondText,
                        style = secondTextStyle,
                        color = mainTextColor.value,
                    )
                }
            }
            Icon(
                modifier = Modifier.size(10.dp),
                painter = painterResource(id = R.drawable.vector),
                contentDescription = "",
                tint = mainTextColor.value
            )
        }
    }
}

