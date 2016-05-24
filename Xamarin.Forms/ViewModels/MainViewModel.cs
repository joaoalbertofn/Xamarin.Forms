using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Xamarin.Forms
{
    public class MainViewModel : ViewModelBase 
    {
        //Propertys that represent controls on the screen
        #region Propertys

        // entryUser
        private string _user;
        public string User {
            get { return _user;}
            set {
                _user = value;
                this.Notify("User");
            }
        }

        // entryItems
        private ObservableCollection<Monkey> _items;
        public ObservableCollection<Monkey> Items {
            get { return _items;}
            set {
                _items = value;
                this.Notify("Items");
            }
        }

        #endregion


        #region User Interection Commands and Events

        public ICommand BuscarClickedCommand {get;set;}

        private  void BuscarClicked()
        {
            MonkeyServices mk = new MonkeyServices();
            Items =  mk.GetMonkeysAsync().Result;
        }
            
        #endregion 


        // Constructor
        public MainViewModel()
        {
            this.BuscarClickedCommand = new Command(this.BuscarClicked);
        }
    }
}

