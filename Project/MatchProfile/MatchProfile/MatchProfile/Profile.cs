using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchProfile
{
    public class Profile
    {

        // FIELDS

        private string name;
        //private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //Properties are used to:
        //validate values
        //control external access
        [Range(18,int.MaxValue)]
        private int age;
            /*
        {
            get { return age; }

            set { 

                if(value >= 18)
                {
                    age = value;
                }else{
                age = "";
            }
                 
        }
            */
        //CONSTRUCTOR


        public Profile(string name, int age, string city, string country, string pronouns = "He/She")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            hobbies = new string[4];
        }

        //METHOD

        public string ViewProfile()
        {
            /*
            var allHobbies = " ";
            foreach (var hobb in this.hobbies)
            {
                allHobbies = allHobbies + hobb + ", ";
            }
            */
            string userProfile = $"Name: {name};\n Age: {age};\n City: {city};\n Country: {country};\n Hobbies: {SetHobbies(this.hobbies)} ";

            return userProfile;
        }

        public string SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;

            var allHobbies = " ";
            foreach (var hobb in this.hobbies)
            {
                allHobbies = allHobbies + hobb + ", ";
            }

            return allHobbies;

        }
    }
 }
