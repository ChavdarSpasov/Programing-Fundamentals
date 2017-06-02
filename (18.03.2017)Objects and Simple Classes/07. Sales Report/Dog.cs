

namespace _07.Sales_Report
{
    class Dog
    {
        public string  Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public bool Inbed { get; set; }

        public bool HasEaten { get; set; }


        public void IsAsleep()
        {
            if (HasEaten)
            {
                Inbed = true;
            }            
        }

        public void DogEatCat(Cat cat)
        {
            if (cat != null)
            {
                HasEaten = true;
            }
        }        
    }
}
