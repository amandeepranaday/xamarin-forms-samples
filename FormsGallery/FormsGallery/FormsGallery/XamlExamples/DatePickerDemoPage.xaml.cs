﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsGallery.XamlExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerDemoPage : ContentPage
    {
        public DatePickerDemoPage()
        {
            InitializeComponent();
        }
    }
}