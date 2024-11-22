using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Login___Register_Form
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public User(int id, string username, string name, string gender, string email, string password, string phoneNumber, string position)
        {
            Id = id;
            Username = username;
            Name = name;
            Position = position;
            Gender = gender;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
    public class UserRepository
    {
        public User[] users;
        public List<User> usersList = new List<User>();
        private int counter;
        private int maxUsers = 3;

        public UserRepository()
        {
            users = new User[maxUsers];
            counter = 0;
        }

        public bool RegisterUser(int id, string username, string name, string gender, string email, string password, string phoneNumber, string position)
        {       
            for (int i = 0; i < counter; i++) 
            {
                if (users[i].Username == username || users[i] == null) 
                {
                    return false;
                }
                if (users[i].Position == position)
                {
                    return false;
                }
            }

            users[counter] = new User(id, username, name, gender, email, password, phoneNumber, position);
            usersList.Add(users[counter]);
            counter++;
            return true;
        }

        public bool LoginUser(string username, string password) 
        {
            for (int i = 0; i < maxUsers; i++)
            {
                if (users[i] == null)
                {
                    return false;
                }
                else if (users[i].Username == username && users[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public string UserPosition(string username, string password)
        {
            for (int i = 0; i < counter; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    return users[i].Position;
                }
            }
            
            return "tetot";
        }

        public bool isArrayFull()
        {
            return counter >= maxUsers;
        }
    }
}
