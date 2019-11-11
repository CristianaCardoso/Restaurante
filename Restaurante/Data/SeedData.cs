using Microsoft.AspNetCore.Identity;
using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Data
{
    public class SeedData
    {
public static  void Populate(RestauranteDbContext bd )//apagar o modeles
        {


        }
        public static async Task PopulateUsers(UserManager<IdentityUser> userManager)//apagar names
        {
            const string ADMIN_USERNAME = "adin@ipg.pt";
            const string ADMIN_PASSEWORD = "Secret123$";


            IdentityUser user =  await userManager.FindByNameAsync(ADMIN_USERNAME);//await -esperar
            if (user  == null)
            {
                user = new IdentityUser {
                    UserName = ADMIN_USERNAME,
                    Email = ADMIN_USERNAME
                };

                await userManager.CreateAsync(user, ADMIN_PASSEWORD);
            }
        //criar os empregados todos
        }

    }
}
