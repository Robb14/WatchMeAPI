
//Uncomment to seed random data



// using AutoFixture;
// using WatchMe.Models;
// namespace WatchMe.Data
// {
//     public static class Seeder
//     {
//         static int generateId(int id)
//         {
//            return id++;
//         }
//         public static void Seed(this DataContext dbContext)
//         {
//             if (!dbContext.Users.Any())
//             {
//                 Fixture fixture = new Fixture();
//                 fixture.Customize<User>(User => User.Without(p => p.Id));
//                 fixture.Customize<Bar>(Bar => Bar.Without(b => b.Id));
//                 //--- The next two lines add 100 rows to your database
//                 List<User> Users = fixture.CreateMany<User>(10).ToList();
//                   List<Bar> Bars = fixture.CreateMany<Bar>(10).ToList();
//                 dbContext.AddRange(Users);
//                 dbContext.AddRange(Bars);
//                 dbContext.SaveChanges();
//             }
//         }
//     }
// }
