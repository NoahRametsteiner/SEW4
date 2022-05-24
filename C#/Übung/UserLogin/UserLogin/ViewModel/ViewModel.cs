using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Xml;
using System.Diagnostics;
using UserLogin.ViewModel;
using System.Security;
using UserLogin.View;

namespace UserLogin.ViewModel
{   
    class ViewModel : INotifyPropertyChanged
    {
        #region DATABASE
        /*
            drop database if exists passworddb;
            create database passworddb default character set=utf8 default collate utf8_general_ci;

            use passworddb;
            show tables;

            create table user(
	            uid int,
	            email varchar(200),
	            password varchar(88),
	            salt varchar(16),
	            primary key(uid)
            );

            create table username(
	            uid integer,
	            username varchar(50),
	            primary key(uid)
            );
         */
        #endregion


        public ICommand Login { get; set; }
        public ICommand Register { get; set; }

        private string DBLogin = @"server=localhost;userid=root;password=;database=passworddb";
        public string Email { get; set; }
        public string Pw { get; set; }

        public ViewModel()
        {
            Login = new RelayCommand(e =>
            {
                bool i = false;
                i = ComparePassword.PasswordCompare(DBLogin, Email, Pw);
                if (i == true)
                {
                    MainPage mainpage = new MainPage();
                    Login loginpage = new Login();
                    mainpage.Show();
                    loginpage.Hide();
                }
            });

            Register = new RelayCommand(e =>
            {
                AddUser.CreateUser(DBLogin, Email, Pw);
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
