﻿namespace Shitlords_Bankomat
{
    public abstract class User
    {
        private string _id;
        private string _passWord;
        public bool IsLoggedIn { get; set; }
        //Menu userMenu
        private DataHandler _dataHandler;

        public User(string id, string passWord)
        {
            _id = id;
            _passWord = passWord;
            IsLoggedIn = false;
            //_dataHandler = new DataHandler;
            //userMenu = new Menu;
        }


    }
}