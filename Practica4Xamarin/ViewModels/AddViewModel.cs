using Practica4Xamarin.Model;
using Practica4Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica4Xamarin.ViewModels
{
    public class AddViewModel
    {
        
        public ICommand OkContact { get; }
        public string Name { get; set; }
        public string Number { get; set; }

        public AddViewModel()
        {
            OkContact = new Command(OnOkCommand);
        }

        private async void OnOkCommand() 
        {
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
    }

   


}
