package com.example.ozonchick_new_version.Screens.SignUp_LogIn

import androidx.compose.foundation.Image
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.text.ClickableText
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Checkbox
import androidx.compose.material3.CheckboxDefaults
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.collectAsState
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.saveable.rememberSaveable
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.SpanStyle
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.buildAnnotatedString
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.text.style.BaselineShift
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.text.withStyle
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import cafe.adriel.voyager.core.registry.rememberScreen
import cafe.adriel.voyager.core.screen.Screen
import cafe.adriel.voyager.navigator.LocalNavigator
import com.example.ozonchick_new_version.Data_Layer.data.db.emailSharedUser
import com.example.ozonchick_new_version.Data_Layer.data.ui.components.SignUp_LogIn_Components.SignUp_LogIn_Button
import com.example.ozonchick_new_version.Data_Layer.data.ui.components.SignUp_LogIn_Components.SignUp_LogIn_OutlinedTextField
import com.example.ozonchick_new_version.Data_Layer.data.ui.text_tema.Tema
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Gray_Color_Passive_Secondary
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Primary_Color
import com.example.ozonchick_new_version.Presentation_Layer.Models.SignUp_ViewModel
import com.example.ozonchick_new_version.R
import com.example.ozonchick_new_version.Screens.navigation.screen_provider.Home_Provider
import org.koin.androidx.compose.koinViewModel

class LogIn_Screen : Screen {
    @Composable
    override fun Content() {
        LogIn_Construct()
    }
}

@Composable
fun LogIn_Construct(vm: SignUp_ViewModel = koinViewModel()) {
    val context = LocalContext.current
    val navigator = LocalNavigator.current
    val checkedState = remember { mutableStateOf(false) }
    val screen = rememberScreen(provider = Home_Provider.Profile)

    var access = vm.accessAuth.collectAsState()

    Column(
        horizontalAlignment = Alignment.Start,
        verticalArrangement = Arrangement.Center,
        modifier = Modifier
            .fillMaxWidth()
            .padding(start = 24.dp, end = 24.dp)
    ) {
        Column(
            modifier = Modifier
                .fillMaxWidth()
                .padding(top = 155.dp)
        ) {
            Text(
                text = "Welcom Back",
                style = Tema.MainText_24_30_500,
            )
            Text(
                text = "Fill in your email and password to continue",
                style = Tema.SecondaryText_14_16_400,
                modifier = Modifier.padding(top = 8.dp)
            )
        }
        Column(
            modifier = Modifier
                .fillMaxWidth()
                .padding(top = 20.dp)
        ) {
            Column(
            ) {
                Text(
                    text = "Email Address",
                    style = Tema.PassiveSideText_14_16_500
                )
                SignUp_LogIn_OutlinedTextField(
                    value = vm.emailUser.value,
                    onValueChange = { vm.emailUser.value = it },
                    placeholder = {
                        Text(
                            text = "*******@mail.com",
                            style = Tema.SecondaryText_14_16_500
                        )
                    }
                )
                var passwordVisible by rememberSaveable { mutableStateOf(false) }
                Column(
                    modifier = Modifier.padding(top = 24.dp)
                ) {
                    Text(text = "Password", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                    SignUp_LogIn_OutlinedTextField(
                        value = vm.passwordUser.value,
                        onValueChange = { vm.passwordUser.value = it },
                        placeholder = {
                            Text(
                                text = "***********",
                                style = Tema.PassiveSideText_14_16_500
                            )
                        },
                        trailingIcon = {
                            Image(
                                painter = painterResource(id = R.drawable.eye_slash),
                                contentDescription = "Показать пароль",
                                contentScale = ContentScale.Crop,
                                modifier = Modifier
                                    .size(24.dp)
                                    .clickable {
                                        passwordVisible = !passwordVisible
                                    },
                            )
                        },
                        visualTransformation = if (passwordVisible) VisualTransformation.None else PasswordVisualTransformation(),
                    )
                }
            }
//            Email(MainText = "Email Address", InsideText = "*******@mail.com")
//            Password(MainText = "Password", InsideText = "***********")
        }

        Row(
            verticalAlignment = Alignment.CenterVertically,
            horizontalArrangement = Arrangement.Start,
            modifier = Modifier
                .fillMaxWidth()
                .padding(top = 10.dp)
        ) {
            Checkbox(
                checked = vm.rememberUser.value,
                onCheckedChange = { vm.rememberUser.value = it },
                modifier = Modifier
                    .size(35.dp),
                colors = CheckboxDefaults.colors(
                    uncheckedColor = Gray_Color_Passive_Secondary,
                    checkedColor = Primary_Color
                ),
            )
            Row(horizontalArrangement = Arrangement.spacedBy(90.dp, Alignment.Start)) {
                Text(
                    text = "Remember password",
                    // Body regular 12
                    style = TextStyle(
                        fontSize = 12.sp,
                        lineHeight = 16.sp,
                        fontWeight = FontWeight(500),
                        color = Color(0xFFA7A7A7),
                        textAlign = TextAlign.Center,
                    )
                )
                Text(
                    text = "Forgot Password?",

                    // Body medium 12
                    style = TextStyle(
                        fontSize = 12.sp,
                        lineHeight = 16.sp,
                        fontWeight = FontWeight(500),
                        color = Color(0xFF0560FA),
                        textAlign = TextAlign.Center,
                    ),
                )
            }
        }
        if (access.value) {
            emailSharedUser.value = vm.emailUser.value
            navigator?.replaceAll(screen)
        }
        Column(
            horizontalAlignment = Alignment.CenterHorizontally,
            verticalArrangement = Arrangement.Center,
            modifier = Modifier.padding(top = 64.dp)
        ) {
            SignUp_LogIn_Button(
                enabled = vm.ConstructProverka(vm.emailUser.value, vm.passwordUser.value),
                onClick = {
//                    Log.d("Авторизация", vm.Auth().toString())
                    vm.Auth(context)


                },
                colors = if (vm.ConstructProverka(vm.emailUser.value, vm.passwordUser.value)) {
                    ButtonDefaults.buttonColors(containerColor = Primary_Color)
                } else {
                    ButtonDefaults.buttonColors(containerColor = Gray_Color_Passive_Secondary)
                }
            ) {
                Text(
                    text = "Log in",
                    style = Tema.ButtonText_16_16_700_Neutral
                )
            }

            val SignUpText = buildAnnotatedString {
                withStyle(
                    style = SpanStyle(
                        color =  Gray_Color_Passive_Secondary,
                        fontSize = 14.sp,
                        fontWeight = FontWeight(400),
                    )
                )
                {
                    append("Already have an account? ")
                }

                pushStringAnnotation(tag = "click", annotation = "click")
                withStyle(
                    SpanStyle(
                        color = Primary_Color,
                        fontSize = 14.sp,
                        fontWeight = FontWeight(400),
                    )
                ) {
                    append("Sign Up")
                }
            }
            ClickableText(
                text = SignUpText,
                onClick = {
                    SignUpText.getStringAnnotations(tag = "click", start = it, end = it).firstOrNull()
                        ?.let {
                            navigator?.replaceAll(SignUp_Screen())
                        }
                },
                modifier = Modifier.padding(top = 20.dp)
            )
        }
        Column(
            horizontalAlignment = Alignment.CenterHorizontally,
            verticalArrangement = Arrangement.Center,
            modifier = Modifier
                .fillMaxWidth()
                .padding(top = 18.dp, bottom = 28.dp)
        ) {
            Text(
                text = "or sign in using",
                style = Tema.SecondaryText_14_16_400,
            )
            Image(
                painter = painterResource(id = R.drawable.akar_icons_google_contained_fill),
                contentDescription = "Нижняя картинка",
                modifier = Modifier
                    .padding(top = 8.dp)
                    .size(16.dp)
            )
        }
    }

}

@Composable
fun Email(MainText: String, InsideText: String) {
    var text by remember { mutableStateOf("") }
    var passwordVisible by rememberSaveable { mutableStateOf(false) }
    Column(
    ) {
        Text(
            text = "$MainText",
            style = Tema.PassiveSideText_14_16_500
        )
        SignUp_LogIn_OutlinedTextField(
            value = text,
            onValueChange = { text = it },
            placeholder = { Text(text = "$InsideText", style = Tema.SecondaryText_14_16_500) }
        )
    }
}

@Composable
fun Password(MainText: String, InsideText: String) {
    var text by remember { mutableStateOf("") }
    var passwordVisible by rememberSaveable { mutableStateOf(false) }
    Column(
        modifier = Modifier.padding(top = 24.dp)
    ) {
        Text(text = MainText, style = Tema.SecondaryText_14_16_500, maxLines = 1)
        SignUp_LogIn_OutlinedTextField(
            value = text,
            onValueChange = { text = it },
            placeholder = {
                Text(
                    text = InsideText,
                    style = Tema.PassiveSideText_14_16_500
                )
            },
            trailingIcon = {
                Image(
                    painter = painterResource(id = R.drawable.eye_slash),
                    contentDescription = "Показать пароль",
                    contentScale = ContentScale.Crop,
                    modifier = Modifier
                        .size(24.dp)
                        .clickable {
                            passwordVisible = !passwordVisible
                        },
                )
            },
            visualTransformation = if (passwordVisible) VisualTransformation.None else PasswordVisualTransformation(),
        )
    }
}