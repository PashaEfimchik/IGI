using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953505_EFIMCHIK.Entities;

namespace WEB_953505_EFIMCHIK.Data
{
    public class DbInitializer
    {
        public DbInitializer() { }
        public static async Task Seed(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                await roleManager.CreateAsync(roleAdmin);
            }

            if (!context.Users.Any())
            {
                var user = new ApplicationUser
                {
                    Email = "user@gmail.com",
                    UserName = "user@gmail.com"
                };
                await userManager.CreateAsync(user, "123456");

                var admin = new ApplicationUser
                {
                    Email = "admin@gmail.com",
                    UserName = "admin@gmail.com"
                };
                await userManager.CreateAsync(admin, "123456");
                admin = await userManager.FindByEmailAsync("admin@gmail.com");
                await userManager.AddToRoleAsync(admin, "admin");
            }

            if (!context.AutoGroups.Any())
            {
                context.AutoGroups.AddRange(
                    new List<AutoGroup>
                    {
                        new AutoGroup {GroupName="Седан"},
                        new AutoGroup {GroupName="Универсал"},
                        new AutoGroup {GroupName="Внедорожник"},
                        new AutoGroup {GroupName="Купе"}
                    });
                await context.SaveChangesAsync();
            }

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new List<Auto>
                    {
                        new Auto{AutoName="Audi A8 D4",
                            Description="Б/У, год: 2015, объем: 4.0, пробег: 110000, расход 20л/100km",
                            Price=21000, AutoGroupId=1, Image="AUDI_A8_D4.jpg"},

                        new Auto{AutoName="Volkswagen Touareg |||",
                            Description="Новый, год: 2020, объем: 3.0, пробег: 7200, расход 10л/100km",
                            Price=30000, AutoGroupId=3, Image="VW_Touareg3.jpg"},

                        new Auto{AutoName="Porsche 911 GT3 992",
                            Description="Новый, год: 2021, объем: 4.0, пробег: 1000, расход 35л/100km",
                            Price=280000, AutoGroupId=4, Image="PORSCHE_911.jpg"},

                        new Auto{AutoName="Audi A6 C7 Allroad",
                            Description="Б/У, год: 2015, объем: 3.0, пробег: 56000, расход 15л/100km",
                            Price=28000, AutoGroupId=2, Image="AUDI_A6_C7_Allroad.jpg"}
                    });
                await context.SaveChangesAsync();
            }
        }
    }
}
