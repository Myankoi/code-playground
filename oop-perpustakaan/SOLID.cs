using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_perpustakaan
{
    class Database
    {
        private ArrayList libraryDatabase;

        public Database()
        {
            libraryDatabase = new ArrayList();
        }

        public void connect()
        {

        }

        public void disconnect()
        {

        }

        public void query(String query)
        {

        }

        public void save()
        {

        }
    }

    class User
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int gender { get; set; }
        public DateTime date_in { get; set; }
    }

    class UserRepository
    {
        private Database database;

        public UserRepository(Database database)
        {
            this.database = database;
        }

        public User getUserById(string id)
        {
            database.query("SELECT * FROM user WHERE id == " + id);
            return new User();
        }

        public List<User> getUsers()
        {
            database.query("SELECT * FROM user WHERE active == true");
            return new List<User>();
        }

        public void saveUser(User user)
        {
            database.save();
        }
    }

    class SearchUserUseCase
    {
        private UserRepository userRepository;

        public SearchUserUseCase(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> run(string search)
        {
            List<User> users = userRepository.getUsers();
            users.Where(x => x.nama.Contains(search));
            return users;
        }
    }

    public void main()
    {
        Database db = new Database();
        UserRepository userRepository = new UserRepository(db);
        UserRepository user2Repository = new UserRepository(db);
        UserRepository userRepository = new UserRepository(db);
        UserRepository userRepository = new UserRepository(db);
    }
}
