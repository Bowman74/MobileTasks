﻿using Microsoft.WindowsAzure.MobileServices;
using MobileTasks.Windows.ViewModels;
using Windows.UI.Xaml;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileTasks.Windows.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Login : MobileTasksPage
    {
        public Login()
        {
            this.InitializeComponent();

			this.WireUpViewModel(new LoginViewModel());
        }

        private async void Facebook_Click(object sender, RoutedEventArgs e)
        {
            await ((LoginViewModel)this.ViewModel).AuthenticateAsync(MobileServiceAuthenticationProvider.Facebook);
        }

        private async void Microsoft_Click(object sender, RoutedEventArgs e)
        {
            await ((LoginViewModel)this.ViewModel).AuthenticateAsync(MobileServiceAuthenticationProvider.MicrosoftAccount);
        }

        private async void Twitter_Click(object sender, RoutedEventArgs e)
        {
            await ((LoginViewModel)this.ViewModel).AuthenticateAsync(MobileServiceAuthenticationProvider.Twitter);
        }

        private async void Google_Click(object sender, RoutedEventArgs e)
        {
            await ((LoginViewModel)this.ViewModel).AuthenticateAsync(MobileServiceAuthenticationProvider.Google);
        }
    }
}
