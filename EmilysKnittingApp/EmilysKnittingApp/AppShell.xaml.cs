//using EmilysKnittingApp.ViewModels;
using EmilysKnittingApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EmilysKnittingApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AboutApp), typeof(AboutApp));
            Routing.RegisterRoute(nameof(FeedbackPage), typeof(FeedbackPage));
            Routing.RegisterRoute(nameof(KnittingNotes), typeof(KnittingNotes));
            Routing.RegisterRoute(nameof(PatternCreator), typeof(PatternCreator));
            Routing.RegisterRoute(nameof(RowStitchCounter), typeof(RowStitchCounter));
            Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
