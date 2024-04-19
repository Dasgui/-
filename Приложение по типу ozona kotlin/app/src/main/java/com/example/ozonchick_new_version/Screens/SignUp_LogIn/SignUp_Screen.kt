package com.example.ozonchick_new_version.Screens.SignUp_LogIn

import android.util.Log
import androidx.compose.foundation.Image
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.text.ClickableText
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Checkbox
import androidx.compose.material3.CheckboxDefaults
import androidx.compose.material3.Text
import androidx.compose.material3.TextFieldDefaults
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
import androidx.compose.ui.text.buildAnnotatedString
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.text.withStyle
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import cafe.adriel.voyager.core.registry.rememberScreen
import cafe.adriel.voyager.core.screen.Screen
import cafe.adriel.voyager.navigator.LocalNavigator
import com.example.ozonchick_new_version.Data_Layer.data.ui.components.SignUp_LogIn_Components.SignUp_LogIn_Button
import com.example.ozonchick_new_version.Data_Layer.data.ui.components.SignUp_LogIn_Components.SignUp_LogIn_OutlinedTextField
import com.example.ozonchick_new_version.Data_Layer.data.ui.text_tema.Tema
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Gray_Color_Passive_Secondary
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Primary_Color
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Color_Red
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Text_Color_Active
import com.example.ozonchick_new_version.Data_Layer.data.ui.theme.Text_Color_Yellow
import com.example.ozonchick_new_version.Data_Layer.repository.SignUp_LogIn_Case.getName
import com.example.ozonchick_new_version.Presentation_Layer.Models.SignUp_ViewModel
import com.example.ozonchick_new_version.R
import com.example.ozonchick_new_version.Screens.navigation.screen_provider.SignUp_LogIn_Provider
import org.koin.androidx.compose.koinViewModel

class SignUp_Screen : Screen {
    @Composable
    override fun Content() {
        Create_Account()
    }
}

@Composable
fun SignUp_Construct() {

}


@Composable
fun Create_Account(vm: SignUp_ViewModel = koinViewModel()) {
    val screen = rememberScreen(provider = SignUp_LogIn_Provider.LogIn)
    val navigator = LocalNavigator.current
    val context = LocalContext.current
    val access = vm.accessRegistrait.collectAsState()
    /*    var text by remember { mutableStateOf("") }
        val checkedState = remember { mutableStateOf(false) }*/






    LazyColumn(
        modifier = Modifier
            .fillMaxWidth()
            .padding(start = 24.dp, end = 23.dp)
    ) {
        item {
            Column(
                modifier = Modifier.padding(top = 33.dp, bottom = 9.dp)
            ) {
                Text(
                    text = "Create an account",
                    style = Tema.MainText_24_30_500
                )
                Text(
                    text = "Complete the sign up process to get started",
                    modifier = Modifier.padding(top = 8.dp),
                    style = Tema.SecondaryText_14_16_500
                )
            }
            val getUser = getName()
            var text by remember { mutableStateOf("") }
            Column(modifier = Modifier.padding(top = 24.dp)) {
                Text(text = "Name", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                SignUp_LogIn_OutlinedTextField(
                    value = vm.nameUser.value,
                    onValueChange = { vm.nameUser.value = it },
                    placeholder = {
                        Text(
                            text = getUser.name,
                            style = Tema.PassiveSideText_14_16_500
                        )
                    },
                )
            }
            Column(modifier = Modifier.padding(top = 24.dp)) {
                Text(text = "Phone Number", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                SignUp_LogIn_OutlinedTextField(
                    value = vm.phoneNumber.value,
                    onValueChange = { vm.phoneNumber.value = it },
                    placeholder = {
                        Text(
                            text = "F",
                            style = Tema.PassiveSideText_14_16_500
                        )
                    },
                )
            }
            Column(modifier = Modifier.padding(top = 24.dp)) {
                Text(text = "Email Address", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                SignUp_LogIn_OutlinedTextField(
                    value = vm.emailUser.value,
                    onValueChange = { vm.emailUser.value = it },
                    placeholder = {
                        Text(
                            text = getUser.name,
                            style = Tema.PassiveSideText_14_16_500
                        )
                    },
                    colors = if (vm.ProverkaMail()) {
                        Log.d("Проверка", "true")
                        TextFieldDefaults.colors(
                            focusedContainerColor = Color.White,
                            unfocusedContainerColor = Color.White,
                            focusedIndicatorColor = Gray_Color_Passive_Secondary,
                            unfocusedIndicatorColor = Gray_Color_Passive_Secondary,
                            focusedTextColor = Text_Color_Active,
                            unfocusedTextColor = Text_Color_Active
                        )
                    } else {
                        TextFieldDefaults.colors(
                            focusedContainerColor = Color.White,
                            unfocusedContainerColor = Color.White,
                            focusedIndicatorColor = Color_Red,
                            unfocusedIndicatorColor = Color_Red,
                            focusedTextColor = Color_Red,
                            unfocusedTextColor = Color_Red,
                        )
                    }
                )
            }

            var passwordVisible by rememberSaveable { mutableStateOf(false) }
            var passwordVisible1 by rememberSaveable { mutableStateOf(false) }
            Column(modifier = Modifier.padding(top = 24.dp)) {
                Text(text = "Password", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                SignUp_LogIn_OutlinedTextField(
                    value = vm.passwordUser.value,
                    onValueChange = { vm.passwordUser.value = it },
                    placeholder = {
                        Text(
                            text = getUser.name,
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
            Column(modifier = Modifier.padding(top = 24.dp)) {
                Text(text = "Confirm Password", style = Tema.SecondaryText_14_16_500, maxLines = 1)
                SignUp_LogIn_OutlinedTextField(
                    value = vm.confirmPassword.value,
                    onValueChange = { vm.confirmPassword.value = it },
                    placeholder = {
                        Text(
                            text = getUser.name,
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
                                    passwordVisible1 = !passwordVisible1
                                },
                        )
                    },
                    visualTransformation = if (passwordVisible1) VisualTransformation.None else PasswordVisualTransformation(),
                )
            }



            Row(
                horizontalArrangement = Arrangement.Start,
                verticalAlignment = Alignment.CenterVertically,
                modifier = Modifier.padding(top = 37.dp, end = 46.dp)
            ) {
                Checkbox(
                    checked = vm.EnableCheck.value,
                    onCheckedChange = { vm.EnableCheck.value = it },
                    colors = CheckboxDefaults.colors(
                        checkedColor = Primary_Color,
                        uncheckedColor = Primary_Color,
                    )
                )

                Text(
                    text = buildAnnotatedString {
                        withStyle(
                            style = SpanStyle()
                        )
                        {
                            append("By ticking this box, you agree to our ")
                        }
                        withStyle(
                            style = SpanStyle(
                                color = Text_Color_Yellow
                            )
                        )
                        {
                            append("Terms and conditions and private policy")

                        }
                    },
                    style = Tema.SecondaryText_14_16_400,
                    textAlign = TextAlign.Center,
                    modifier = Modifier.clickable { }

                )

            }
            if (access.value) {
                navigator?.replaceAll(screen)
            }
            Column(
                horizontalAlignment = Alignment.CenterHorizontally,
                verticalArrangement = Arrangement.Center,
                modifier = Modifier.padding(top = 64.dp)
            ) {
                SignUp_LogIn_Button(
                    enabled = vm.Proverka(),
                    onClick = {
/*                        navigator?.replaceAll(screen)*/
                        vm.Registrait(context)
/*                        vm.ClearParametres()*/
                    },
                    colors = if (vm.Proverka()) {
                        ButtonDefaults.buttonColors(containerColor = Primary_Color)
                    } else {
                        ButtonDefaults.buttonColors(containerColor = Gray_Color_Passive_Secondary)
                    }
                ) {
                    Text(
                        text = "Sign Up",
                        style = Tema.ButtonText_16_16_700_Neutral
                    )
                }
                val SignInText = buildAnnotatedString {
                    withStyle(
                        style = SpanStyle(
                            color =Gray_Color_Passive_Secondary,
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
                        append("Sign in")
                    }
                }
                ClickableText(
                    text = SignInText,
                    onClick = {
                        SignInText.getStringAnnotations(tag = "click", start = it, end = it).firstOrNull()
                            ?.let {
                                navigator?.replaceAll(LogIn_Screen())
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
//                    textAlign = TextAlign.Center
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
}

@Composable
fun Create_Account_Min_Elem(Maint_text: String, Inside_Text: String, vm: SignUp_ViewModel) {
    val getUser = getName()
    var text by remember { mutableStateOf("") }
    Column(modifier = Modifier.padding(top = 24.dp)) {
        Text(text = "$Maint_text", style = Tema.SecondaryText_14_16_500, maxLines = 1)
        SignUp_LogIn_OutlinedTextField(
            value = vm.nameUser.value,
            onValueChange = { vm.nameUser.value = it },
            placeholder = { Text(text = getUser.name, style = Tema.PassiveSideText_14_16_500) },
        )
    }
}

@Composable
fun Create_Account_Min_Elem_Password(Maint_text: String, Inside_Text: String) {
    var text by remember { mutableStateOf("") }
    var passwordVisible by rememberSaveable { mutableStateOf(false) }
    Column(modifier = Modifier.padding(top = 24.dp)) {
        Text(text = "$Maint_text", style = Tema.SecondaryText_14_16_500, maxLines = 1)
        SignUp_LogIn_OutlinedTextField(
            value = text,
            onValueChange = { text = it },
            placeholder = { Text(text = Inside_Text, style = Tema.PassiveSideText_14_16_500) },
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
