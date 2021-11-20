﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace XamarinMaui
{
    public partial class MainPage : ContentPage
    {
        private Command _shareCommand = null;
        public Command ShareCommand
        {
            get { return _shareCommand; }
            set { _shareCommand = value; OnPropertyChanged(); }
        }
        public MainPage()
        {
            InitializeComponent();

            ShareCommand = new Command<string>(
            async (string uri) =>
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Uri = uri,
                    Title = "Share Web Link"
                });
            });
        }
    }
}