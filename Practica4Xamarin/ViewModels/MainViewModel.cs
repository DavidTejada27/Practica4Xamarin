using Practica4Xamarin.Model;
using Practica4Xamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Practica4Xamarin.ViewModels
{

    public class MainViewModel
    {
        public ObservableCollection<Contact> Contacts { get;}

        public ICommand SelectedContactCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand MoreCommand { get; }

        private Contact _contact;

        public Contact SelectedContact 
        {
            get { return _contact; }
            set 
            { 
                _contact = value;

                if (_contact != null) 
                {
                    SelectedContactCommand.Execute(_contact);
                }
            }

        }

        public MainViewModel()
        {
            AddCommand = new Command(OnAdd);
            DeleteCommand = new Command<Contact>(OnDelete);
            MoreCommand = new Command<Contact>(OnMore);
            Contacts = new ObservableCollection<Contact>()
            {
                new Contact("David","809-111-1111"),
                new Contact("Pepe","809-222-2222"),
                new Contact("Coco","809-333-3333"),
                new Contact("Jose","809-444-4444"),
                new Contact("Cesar","809-555-5555"),
                new Contact("Nacho","809-666-6666"),
                new Contact("Helen","809-777-7777"),
                new Contact("Pablo","809-888-8888"),
                new Contact("Oscar","809-999-9999"),
                new Contact("Victor","809-121-1212"),
                new Contact("Alberto","809-131-1313"),
                new Contact("Matias","809-141-1414"),
                new Contact("Marcos","809-151-1515"),
                new Contact("Estiven","809-161-1616"),
                new Contact("Laura","809-171-1717")
               
               
            };
        }

        private async void OnMore(Contact contact)
        {
            
            var MoreAction = await App.Current.MainPage.DisplayActionSheet(null, "Cancel", null, $"Call {contact.Number}", "Edit" );

            if (MoreAction == $"Call {contact.Number}") 
            {
                PhoneDialer.Open(contact.Number);
            }
        }

        private void OnDelete(Contact contact)
        {
           
            if (Contacts.Contains(contact)) 
            {
                Contacts.Remove(contact);
            }
        }

        private async void OnAdd() 
        {
            
             await App.Current.MainPage.Navigation.PushAsync(new AddPage());
        }

       
    }

   
}
