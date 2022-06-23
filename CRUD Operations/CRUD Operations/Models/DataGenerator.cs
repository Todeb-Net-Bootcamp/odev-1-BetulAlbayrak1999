using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operations.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Users.Any()) { return; }
                if (context.Posts.Any()) { return; }

                context.Users.AddRange(
                    new User { Id = 1, Username = "AhmetXX", Name = "Ahmet", Surname = "AhmetXX", BirthDate = "12/12/12" , TC = "98782390802"},
                    new User { Id = 2, Username = "SamiXX", Name = "Sami", Surname = "SamiXX", BirthDate = "12/12/12", TC = "98782390802" },
                    new User { Id = 3, Username = "SümeyyaXX", Name = "Sümeyya", Surname = "SümeyyaXX", BirthDate = "12/12/12", TC = "98782390802" }
                    );

                context.Posts.AddRange(
                    new Post { Id = 1, Title = "Title-One", Body = "BodyOne", UserId = 1},
                    new Post { Id = 2, Title = "Title-2", Body = "Body2", UserId = 2 },
                    new Post { Id = 3, Title = "Title-3", Body = "Body3", UserId = 1 }
                     );

                context.SaveChanges();
            }
        }
    }
}