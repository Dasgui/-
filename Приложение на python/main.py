import re
import sqlite3
import tkinter
from tkinter import *
NameTable = "Users"
otvetZaprosa = ""
class DB:
    # конструктор класса
    def __init__(self):
        # соединяемся с файлом базы данных
        self.conn = sqlite3.connect("Компьютерный_клуб.db")
        # создаём курсор для виртуального управления базой данных
        self.cur = self.conn.cursor()


    def __del__(self):
        # отключаемся от базы при завершении работы
        self.conn.close()

    def view(self):
        # выбираем все записи о покупках
        self.cur.execute(f"SELECT * FROM Rabotniki")
        # собираем все найденные записи в колонку со строками
        rows = self.cur.fetchall()
        # возвращаем сроки с записями расходов
        return rows

    def delete(self, idDelet):
        # формируем запрос на удаление выделенной записи по внутреннему порядковому номеру
        self.cur.execute(f"DELETE FROM Rabotniki WHERE Id_rabotnik=?", idDelet)
        # сохраняем изменения
        self.conn.commit()

    # добавляем новую запись
    def insertAccaunt(self, name="", password=""):
        # формируем запрос с добавлением новой записи в БД
        self.cur.execute(f"INSERT INTO {NameTable} VALUES (NULL,?,?)", (name,password))
        # сохраняем изменения
        self.conn.commit()

    def insert(self, student, name):
        # формируем запрос с добавлением новой записи в БД
        self.cur.execute(f"INSERT INTO Rabotniki VALUES (NULL,?,?)", (student, name))
        # сохраняем изменения
        self.conn.commit()

    # обновляем информацию о покупке
    def update(self, id, product, price):
        # формируем запрос на обновление записи в БД
        self.cur.execute("UPDATE buy SET product=?, price=? WHERE id=?", (product, price, id,))
        # сохраняем изменения
        self.conn.commit()
    def updateAccount(self, password:str, userId:int):
        global errorText
        global okeyText
        try:
            print(userId)
            otvet = len(password) > 9 and all(re.search(p, password) for p in ('[A-Z]', r'\d', '[a-z]'))
            print(otvet)
            if otvet:
                # формируем запрос на обновление записи в БД
                self.cur.execute(f"UPDATE {NameTable} SET user_password=? WHERE user_id=?", (password, userId))
                # сохраняем изменения
                self.conn.commit()
                okeyText = "О, вы изменили пароль!"
                user_label_2["text"] = okeyText
                admin_label_2["text"] = okeyText
            else:
                errorText = "Пароль должен иметь длину не меньше 9, имея большую букву и маленькую"
                user_label_1["text"] = errorText
                admin_label_1["text"] = errorText
        except:
            print("Проблемка")
            errorText = "Пароль должен иметь длину не меньше 9, имея большую букву и маленькую"
            user_label_1["text"] = errorText

    def search(self, product="", price=""):
        # формируем запрос на поиск по точному совпадению
        self.cur.execute("SELECT * FROM buy WHERE product=?", (product,))
        # формируем полученные строки и возвращаем их как ответ
        rows = self.cur.fetchall()
        return rows

    def searchAccaunt(self, name="", password=""):
        global RealUserNow
        global otvetZaprosa
        # формируем запрос на поиск по точному совпадению
        try:
            localOtvet = self.cur.execute(f"SELECT * FROM {NameTable} WHERE user_name=? AND user_password=?",
                                          (name, password))
            bd_id,bd_Name, bd_Password, bd_Role = self.cur.fetchone()
            if (len(bd_Name) != 0) or (len(bd_Password) != 0):
                print("Он зашел")
            elif (len(bd_Name) == 0) or (len(bd_Password) == 0):
                print("Не зашли")
            if bd_Role == "Пользователь":
                print("О так вы пользователь")
                RealUserNow = bd_id
                registr_window.withdraw()
                common_user_window.deiconify()
            elif bd_Role == "Администратор":
                print("о так вы администратор")
                RealUserNow = bd_id
                registr_window.withdraw()
                common_admin_window.deiconify()
        except:
            otvetZaprosa = "Проверьте правильность пароля или наличие БД"
            print("Не зашли")
            register_label_1["text"] = otvetZaprosa
        # localOtvet = self.cur.execute(f"SELECT * FROM {NameTable} WHERE user_name=? AND user_password=?", (name,password))


        # return rows


def view_command():
    # очищаем список в приложении
    list1.delete(0, END)
    # проходим все записи в БД
    for row in db.view():
        # и сразу добавляем их на экран
        list1.insert(END, row)


def password(data) -> bool:
    otvet = len(data.get()) > 9 and all(re.search(p, data.get()) for p in ('[A-Z]', r'\d', '[a-z]'))
    print(otvet)
    if otvet:
        registr_window.withdraw()
        auth_window.deiconify()
    return otvet
def update_account_password(localPassword:str):
    db.updateAccount(localPassword, RealUserNow)
def check_account(localname:str,localpassword:str):
    db.searchAccaunt(localname, localpassword)
def view_command():
    # очищаем список в приложении
    list1.delete(0, END)
    # проходим все записи в БД
    for row in db.view():
        # и сразу добавляем их на экран
        list1.insert(END, row)
def delete_command():
    # удаляем запись из базы данных по индексу выделенного элемента
    otvet = (list1.get(list1.curselection())[0])
    db.delete(otvet)
    # обновляем общий список расходов в приложении
    view_command()
def on_closing():
    # показываем диалоговое окно с кнопкой
    if common_user_window.askokcancel("", "Закрыть программу?"):
        # удаляем окно и освобождаем память
        common_user_window.destroy()
        # сообщаем системе о том, что делать, когда окно закрывается
        common_user_window.protocol("WM_DELETE_WINDOW", on_closing)
def on_select():
    # los.curselection() - получение индекса выделенного элемента
    # los.get() - получение элемента по его индексу
    print(list1.get(list1.curselection())[0])

def add_command():
    # добавляем запись в БД
    db.insert(Name_text.get(), Familia_text.get())
    # обновляем общий список в приложении
    view_command()

db = DB()
otvet = False
errorText = ""
okeyText = ""

registr_window = Tk()
registr_window.geometry("500x500")

auth_window = Toplevel()
auth_window.geometry("500x500")
auth_window.withdraw()

common_user_window = Toplevel()
common_user_window.geometry("1080x1080")
common_user_window.withdraw()

common_admin_window = Toplevel()
common_admin_window.geometry("1080x1080")
common_admin_window.withdraw()

name_text = StringVar()
e1 = Entry(registr_window,textvariable=name_text)
e1.grid(row=0, column=1)

password_text = StringVar()
e2 = Entry(registr_window,textvariable=password_text)
e2.grid(row=1, column=1)

# b1 = Button(registr_window,text="Регистрация", width=12, command=lambda: password(name_text))
b1 = Button(registr_window,text="Войти", width=12, command=lambda: check_account(name_text.get(), password_text.get()))
b1.grid(row=0, column=2)

register_label_1 = Label(registr_window)
register_label_1.grid(row=0, column=3)

# l2 = Label(common_user_window,text="Экран пользователя")
# l2.grid(row=0, column=1)

# l3 = Label(common_admin_window,text="Экран админа")
# l3.grid(row=0, column=1)








# Admin

list1 = Listbox(common_admin_window,height=25, width=65)

l1 = Label( common_admin_window,text="Имя", justify=LEFT, padx=0)
l1.grid(row=0, column=0)

l2 = Label( common_admin_window,text="Фамилия", justify=LEFT, padx=0)
l2.grid(row=0, column=2)


Name_text = StringVar()
e1 = Entry(common_admin_window,textvariable=Name_text)
e1.grid(row=0, column=1)

Familia_text = StringVar()
e2 = Entry(common_admin_window,textvariable=Familia_text)
e2.grid(row=0, column=3)

Password_admin_text = StringVar()
e3 = Entry(common_admin_window,textvariable=Password_admin_text)
e3.grid(row=1, column=4)

list1 = Listbox( common_admin_window,height=25, width=65)
list1.grid(row=2, column=0, rowspan=6, columnspan=2)


sb1 = Scrollbar(common_admin_window)
sb1.grid(row=2, column=2, rowspan=6)

# привязываем скролл к списку
list1.configure(yscrollcommand=sb1.set)
sb1.configure(command=list1.yview)

b1 = Button(common_admin_window, text="Посмотреть все", width=12, command=view_command)
b1.grid(row=1, column=2) #size of the button

b3 = Button(common_admin_window, text="Добавить", width=12, command=add_command)
b3.grid(row=2, column=2)

b5 = Button( common_admin_window,text="Удалить", width=12, command=delete_command)
b5.grid(row=6, column=3)

b2 = Button(common_admin_window, text="Изменить пароль", width=12, command=lambda : update_account_password(Password_admin_text.get()))
b2.grid(row=2, column=4)

admin_label_1 = Label(common_admin_window, justify=LEFT, padx=0)
admin_label_1.grid(row=3, column=4)

admin_label_2 = Label(common_admin_window, justify=LEFT, padx=0)
admin_label_2.grid(row=4, column=4)

# User
list1 = Listbox(height=25, width=65)

list1 = Listbox(common_user_window, height=25, width=65)
list1.grid(row=2, column=0, rowspan=6, columnspan=2)

sb1 = Scrollbar(common_user_window,)
sb1.grid(row=2, column=2, rowspan=6)

list1.configure(yscrollcommand=sb1.set)
sb1.configure(command=list1.yview)

b1 = Button(common_user_window, text="Посмотреть все", width=12, command=view_command)
b1.grid(row=1, column=2)


Password_text = StringVar()
e2 = Entry(common_user_window,textvariable=Password_text)
e2.grid(row=2, column=3)

b1 = Button(common_user_window, text="Изменить пароль", width=12, command=lambda : update_account_password(Password_text.get()))
b1.grid(row=1, column=4)
user_label_1 = Label(common_user_window, justify=LEFT, padx=0)
user_label_1.grid(row=2, column=4)

user_label_2 = Label(common_user_window, justify=LEFT, padx=0)
user_label_2.grid(row=3, column=4)











registr_window.mainloop()

# import tkinter as tk
# def switch_windows():
#     window1.withdraw()
#     window2.deiconify()
# def back_windows():
#     window2.withdraw()
#     window1.deiconify()
# window1 = tk.Tk()
# button = tk.Button(window1, text="Перейти к Window 2", command=switch_windows)
# button.pack()
# window2 = tk.Toplevel()
# window2.withdraw()
# button = tk.Button(window2, text="Вернуться к Window 1", command=back_windows)
# button.pack()
# label = tk.Label(window2, text="Это Window 2")
# label.pack()
# window1.mainloop()