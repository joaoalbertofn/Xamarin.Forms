using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.Forms
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            //Binding with ViewModel
            this.BindingContext = new MainViewModel();
        }
    }
}

