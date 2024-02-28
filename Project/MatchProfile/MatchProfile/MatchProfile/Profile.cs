using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MatchProfile
{
    public class Profile
    {

        // FIELDS
        private double age;
/*
        private string name;
        private string city;
        private string country;
        private string pronouns;
*/
        private string[] hobbies;
        //Properties are used to:
        //validate values
        //control external access
      //  [Range(18,int.MaxValue)]
       // private int age;
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
        /*
        public int Age 
        {
           get { return age; }
            set
            {
                if (age < 18)
                {
                    Console.WriteLine("Sorry not a valid age!!");
                }
                else
                {
                    age = value;
                }
            } 
        }
        */
        //CONSTRUCTOR


        public Profile(string name, double age, string city, string country, string pronouns = "He/She")
        {
            Name = name;
            Age = age;
            City = city;
            Country = country;
            Pronouns = pronouns;
            Hobbies = new string[4];
        }

     


        //PROPERTIES

        private string Name { get; set; }
        public double Age 
        {
            get {
                return age; 
               } 
            set 
                { 
                    if (value < 18) 
                    {
                        Console.WriteLine("Sorry you are underage!");
                        Console.WriteLine($"You are only {age} years old. Come back again when you are 18.");
                    }
                else {
                          ViewProfile();
                }
                } 
        }
        private string City { get; set; }
        private string Country { get; set; }
        private string Pronouns { get; set; }
        private string[] Hobbies 
        {
            get {  return hobbies; }
            set { } 
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

           
            
            //string userProfile = $"Name: {Name};\n Age: {Age};\n City: {City};\n Country: {Country};\n Hobbies: {SetHobbies(Hobbies)} ";
            string userProfile = $"Name: {Name};\n Age: {Age};\n City: {City};\n Country: {Country};\n ";
            return userProfile;

        }

        public string ViewProfile(string name, int age)
        {
           string userProfile = $"Name: {Name};\n Age: {Age};\n";
            return userProfile;
        }


        public string SetHobbies(string[] Hobbies)
        {
           //Hobbies = hobbies;

            var allHobbies = " ";

            foreach (var hobb in this.hobbies)
            {
                allHobbies = allHobbies + hobb + ", ";
            }

            return allHobbies;

        }
    }

 }
 
