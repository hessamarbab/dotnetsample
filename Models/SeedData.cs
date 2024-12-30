using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace mrbatri.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new UserContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<UserContext>>()))
        {
            // Look for any movies.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            context.Users.AddRange(
                new User{FullName="ali ahmadi",Email="ali@ahmadi.com",RegistrationDate=new DateTime(2019,03,05)},
                new User{FullName="asghar jafari",Email="asghar@jafari.com",RegistrationDate=new DateTime(2020,04,05)},
                new User{FullName="mojtaba pakzadeh",Email="mojtaba@pakzadeh.com",RegistrationDate=new DateTime(2021,08,09)}
            );
            context.SaveChanges();
        }
    }
}