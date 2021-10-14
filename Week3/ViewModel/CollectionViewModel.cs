using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Week3.Model;

namespace Week3.ViewModel
{
    public class CollectionViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();

            Users.Add(new User() { Name = "János" });
            Users.Add(new User() { Name = "Karolin" });
            Users.Add(new User() { Name = "Emese" });
            Users.Add(new User() { Name = "Benedek" });
            Users.Add(new User() { Name = "Károly" });
        }
    }
}
