﻿using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
