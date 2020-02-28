using System;

namespace EntityFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Set avatar = new Set { Name = "Avatar", ReleaseDate = 2018 };
                Set military = new Set { Name = "Military", ReleaseDate = 2017 };
                Set devil = new Set { Name = "Devil", ReleaseDate = 2018 };
                db.Sets.AddRange(avatar, military, devil);
                

                Painter luke = new Painter { Name = "Luke", Surname = "Penberton" };
                Painter jake = new Painter {  Name = "Jake", Surname = "Wasovski" };
                Painter finn = new Painter { Name = "Finn", Surname = "Jilenwhole" };
                db.Painters.AddRange(luke, jake, finn);
                


                Card card1 = new Card { Painter = luke, SerialNumber = 123, Set = avatar };
                Card card2 = new Card { Painter = jake, SerialNumber = 444, Set = military };
                Card card3 = new Card {  Painter = finn, SerialNumber = 333, Set = devil };
                db.Cards.AddRange(card1, card2, card3);
                db.SaveChanges();
            }
        }
    }
}
