using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doing_List.Model;
using Doing_List.Infrastructure.Command;
using System.Windows.Input;
using System.Data.Entity;
using System.Windows;
using System.IO;
using Newtonsoft.Json;

namespace Doing_List.ViewModel
{
    class MainViewModel : ViewModel
    {
        #region name
        private string _DoName;
        public string DoName {
            get { return _DoName; }
            set => Set(ref _DoName, value);
            }
        #endregion

        #region Dedline
        private string _Dedline;
        public string Dedlin
        {
            get { return _Dedline; }
            set => Set(ref _Dedline, value);
        }
        #endregion

        #region SelectedThing
        private Thing _SelectedThing;
        public Thing SelectedThing { get { return _SelectedThing; } set => Set(ref _SelectedThing, value); }
        #endregion

        #region SelectedUser
        private User _SelectedUser;
        public User SelectedUser { get { return _SelectedUser; } set => Set(ref _SelectedUser, value); }
        #endregion

        #region UserName
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set => Set(ref _UserName, value);
        }
        #endregion

        #region UserSurname
        private string _UserSurName;
        public string UserSurName
        {
            get { return _UserSurName; }
            set => Set(ref _UserSurName, value);
        }
        #endregion

        #region Collections
        public ObservableCollection<Thing> ListToDo { get; set; }
        public ObservableCollection<User> Users { get; set; }
        #endregion 

        #region CreateCommand
        public ICommand CreateToDo { get; set; }
        public bool CanCreate(object p) => true;
        public void CreateToDoExe(object p) 
        {
            if (DoName == null || Dedlin == null) 
            {
                dsfg("This name does not fit");
                return;
            }

            Thing thing = new Thing()
            {
                Name =  DoName,
                Dedline = Dedlin,
                Who = SelectedUser
            };

            ListToDo.Add(thing);
            dsfg("Doing sucsessfully added");
        }
        #endregion

        #region DeleteCommand
        public ICommand DeleteToDo { get; set; }
        public bool CanDelete(object p) => true;
        public void DeleteToDoExe(object p)
        {
            string sMessageBoxText = "Do you want to delete this doing";
            string sCaption = "Doing list";

            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    ListToDo.Remove(SelectedThing);
                    break;

                case MessageBoxResult.No:
                    /* ... */
                    break;

                case MessageBoxResult.Cancel:
                    /* ... */
                    break;
            }
        }
        #endregion

        #region CreateUser
        public ICommand CreateUser { get; set; }
        public bool CanCreateUser(object p) => true;
        public void CreateUserExe(object p)
        {
            if (UserName == null || UserSurName == null)
            {
                dsfg("This name does not fit");
                return;
            }

            User us = new User()
            {
                Name = UserName,
                Surname = UserSurName
            };

            Users.Add(us);
            dsfg("User sucsessfully added");
        }
        #endregion

        #region DeleteUser
        public ICommand DeleteUser { get; set; }
        public bool CanDeleteUser(object p) => true;
        public void DeleteUserExe(object p)
        {
            string sMessageBoxText = "Do you want to delete this user";
            string sCaption = "Users";

            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;

            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    Users.Remove(SelectedUser);
                    break;

                case MessageBoxResult.No:
                    /* OK I WILL NOT DELETE YOU!!! HAHA */
                    break;

                case MessageBoxResult.Cancel:
                    /* :D */
                    break;
            }
        }
        #endregion

        #region SaveCommand
        public ICommand SaveData { get; set; }
        public void SaveDataExecute(object p) 
        {
            string jsData = JsonConvert.SerializeObject(ListToDo);
            File.WriteAllText("DoingData.json", jsData);
            string jsUserData = JsonConvert.SerializeObject(Users);
            File.WriteAllText("UserData.json", jsUserData);
        }
        public bool SaveDataCan(object p) => true;
        #endregion

        #region OpenData
        public ICommand OpenData { get; set; }
        public void OpenDataExecute (object p)
        {
            ListToDo = JsonConvert.DeserializeObject<ObservableCollection<Thing>>(File.ReadAllText("C:/Users/Никита/source/repos/Doing List/Doing List/bin/Debug/DoingData.json"));
            OnPropertyChanged();
        }
        public bool OpenDataCan(object p) => true; 
        #endregion

        public void dsfg(string n) 
        {
            MessageBox.Show(n);
        }

        

        public MainViewModel() 
        {
            #region Collection Init
            ListToDo = JsonConvert.DeserializeObject<ObservableCollection<Thing>>(File.ReadAllText("DoingData.json"));
            Users = JsonConvert.DeserializeObject<ObservableCollection<User>>(File.ReadAllText("UserData.json"));
            #endregion

            #region Commands
            CreateToDo = new LambdaCommand(CreateToDoExe, CanCreate);
            DeleteToDo = new LambdaCommand(DeleteToDoExe, CanDelete);

            CreateUser = new LambdaCommand(CreateUserExe, CanCreateUser);
            DeleteUser = new LambdaCommand(DeleteUserExe, CanDeleteUser);

            SaveData = new LambdaCommand(SaveDataExecute, SaveDataCan);
            OpenData = new LambdaCommand(OpenDataExecute, OpenDataCan);
            #endregion
        }
    }
}
