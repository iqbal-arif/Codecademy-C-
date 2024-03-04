/*****************************/
**Supernatural Inheritance**
******************************
/*****************************/
At the Codecademy Guild of the Supernatural, there are three ranks of magicians. They rank from least to most powerful: Pupils, Mages, and Archmages. In this project, you’ll be developing a system in C# to track the weather magicians in the guild and their spells.

    REQUIREMENTS
    ************

    Pupils have a title and can create one weak wind storm.
    Mages have a title and can create a weak wind storm and a weak rain storm.
    Archmages have a title and can create a weak wind storm, a strong rain storm, and a strong lightning storm.

Notice anything shared in these ranks? If we created a class for each type of magician, we would have a lot of duplicated code. For example, every magician has a title and wind storm. To avoid duplication, we’ll use inheritance.
    
    APP DESIGN
    **********

    Pupil is the base class
    Mage inherits from Pupil
    Archmage inherits from Mage

Archmage inherits from Mage, which inherits from Pupil

We’ll also need a Storm class, which stores the essence, strength, and the title of the magician who created it.

FLOW

1. Storm Class  - Define
    1. Storm Class - Storm Class
        1. Automatic Properties
            1. type of storm, like wind or rain
         
           public string Essence { get; private set; }

            2. True if the strom is strong
        
          public bool IsStrong { get; private set; }

            3. the Title  of the magician casting the strom
        
          public string Caster { get; private set; }
      2. Constructor - Storm

             public Storm(string caster, string essence, bool isStrong)
              {
                IsStrong = false;

                Caster = caster;

                Essence = essence;
              }
      3. Method - Announce()

              public string Announce()
               {
                return $"{Caster} cast a weak {Essence} storm!";
               }
2. Pupil Class  - Define
    1. Pupil Class - Pupil Class 
        1. Property - Pupil Name

            public string Title {  get; private set; }
        
        2. Constructor
            public Pupil(string title)
            {
                Title = title;
            }
        3. Method - CastWindStorm() Create a new Storm Object that Returns Type Storm

            public Storm CastWindStorm()
            {
                return new Storm(Title, "wind", false);
            }
        4. Construct Pupil Object with Title; Call Method; and Announce it

            Pupil mezil = new Pupil("Mezil-Kree");

            var storm = mezil.CastWindStorm();

            //ANNOUNCE

            Console.WriteLine(storm.Announce());
