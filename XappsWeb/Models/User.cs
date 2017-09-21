using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace XappsWeb.Models
{
    public class User
    {
        public User(int id, string first_name, string last_name, string avatar)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Avatar = avatar;
        }

        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Avatar { get; set; }

        public static explicit operator User(JToken v)
        {
            throw new NotImplementedException();
        }
    }
}