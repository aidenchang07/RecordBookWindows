using RecordBookWindows.Commands;
using RecordBookWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecordBookWindows.ViewModel
{
    public class AddUserViewModel
    {
        public ICommand AddUserCommand { get; set; }
        public String? Name { get; set; }
        public String? Email { get; set; }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;
        }

        private void AddUser(object obj)
        {
            UserManager.AddUser(
                new User() {
                    Name = Name,
                    Email = Email
                }
            );
        }
    }
}
