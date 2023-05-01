using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Models.DAL;

namespace WebApplication7.Models
{
    public class User
    {
        int userId;
        string fname;
        string lname;
        string email;
        string password;
        string pnumber;
        string gender;
        int birthYear;
        string pGenre;
        string address;
        bool isAdmin;


        public void insert()
        {
            DataServices ds = new DataServices();
            ds.insertUser(this);
        }
        public List<User> Get()
        {
            DataServices ds = new DataServices();
            return ds.getUsers();
        }

        public User Get(string email)
        {
            DataServices ds = new DataServices();
            return ds.getUsers(email);
        }
        public User() { }
        public User(string fname, string lname, string email, string password, string pnumber, string gender, int birthYear, string pGenre, string address, int userId, bool isAdmin)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Email = email;
            this.Password = password;
            this.Pnumber = pnumber;
            this.Gender = gender;
            this.BirthYear = birthYear;
            this.PGenre = pGenre;
            this.Address = address;
            this.UserId = userId;
            this.IsAdmin = isAdmin;
        }

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Pnumber { get => pnumber; set => pnumber = value; }
        public string Gender { get => gender; set => gender = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public string PGenre { get => pGenre; set => pGenre = value; }
        public string Address { get => address; set => address = value; }
        public int UserId { get => userId; set => userId = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}