﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace $safeprojectname$
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            label.Text = MasterConfig.Root.Title;
        }
    }
}
