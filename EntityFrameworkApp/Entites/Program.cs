using System;

namespace EntityFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Set avatar = new Set { Id = 1, Name = "Avatar", ReleaseDate = 2018 };
                Set military = new Set { Id = 2, Name = "Military", ReleaseDate = 2017 };
                Set devil = new Set { Id = 3, Name = "Devil", ReleaseDate = 2018 };
                db.Sets.AddRange(avatar, military, devil);
                db.SaveChanges();

                Painter luke = new Painter { Id = 1, Name = "Luke", Surname = "Penberton" };
                Painter jake = new Painter { Id = 2, Name = "Jake", Surname = "Wasovski" };
                Painter finn = new Painter { Id = 3, Name = "Finn", Surname = "Jilenwhole" };
                db.Painters.AddRange(luke, jake, finn);
                db.SaveChanges();


                Card card1 = new Card { Id = 1, painter = luke, SerialNumber = 123, set = avatar };
                Card card2 = new Card { Id = 2, painter = jake, SerialNumber = 444, set = military };
                Card card3 = new Card { Id = 3, painter = finn, SerialNumber = 333, set = devil };
                db.Cards.AddRange(card1, card2, card3);
                db.SaveChanges();
            }
        }
    }
}
