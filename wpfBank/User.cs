using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfBank
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public User()
        {
        }
        public User(string login, string password, string name, string surname, string patronymic, string phone, string adress,
            string email, string dateofbirth, string placeofbirth)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Phone = phone;
            Adress = adress;
            Email = email;
            DateOfBirth = dateofbirth;
            PlaceOfBirth = placeofbirth;
        }
    }
}