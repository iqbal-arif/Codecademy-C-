using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchProfile
{
    public class Profile
    {

        // FIELDS

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //Properties are used to:
        //validate values
        //control external access

        //CONSTRUCTOR

        public Profile(string name, int age, string city, string country, string pronouns = "He/She")
        {
            this.name = name;
            age = age;
            this.city = city;
            this.country = country;
            this.hobbies =  hobbies;

        }

        //METHOD

        public string ViewProfile()
        {
            foreach(var hobb in hobbies)
            {
                return hobb;
            }

            string userProfile = $"Name: {name};\n Age: {age};\n City: {city};\n Country: {country};\n Hobbies :{hobbies}";

            return userProfile;
        }

        
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
