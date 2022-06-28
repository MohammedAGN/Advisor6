using Advisor6.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Advisor6.Data.Static;

namespace Advisor6.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //في حال قاعدة البيانات فارغة سوف تعتمد البيانات هذه

               //Personal
                if (!context.Personal.Any())
                {
                    context.Personal.AddRange(new List<Personal>()
                    {
                        //new Personal()
                        //{
                        //    FullName = "مستشار 1",
                        //    Gender= Gender.ذكر,
                        //    MarriedStatus = MarriedStatus.اعزب,
                        //    PhoneNo = "07902851338",
                        //    Email ="muhammed_ghazi@gmail.com",
                        //    Address = "كرادة",
                        //    BirthDate = "1982",
                        //    BornPlace = "كرادة",
                        //    Nots = "لايوجد",
                        //    EntryDate = DateTime.Today,
                        //    LastUpdateDate = DateTime.Today,
                        //    DataEntryName = "محمد غازي",
                        //    Image = "http://dotnethow.net/images/actors/actor-1.jpeg",
                        //    PDF = null
                        //},
                         });
                    context.SaveChanges();
                }
                //Employment_info
                if (!context.Employment_info.Any())
                {
                    context.Employment_info.AddRange(new List<Employment_info>()
                    {
                        //new Employment_info()
                        //{
                        //    FullName = "مستشار",
                        //    MainDeptartment = null,
                        //    SubDeptartment = null,
                        //    Salary = null,
                        //    Service_Continuation = Service_Continuation.continuous,
                        //    Job_Title = null,
                        //    Job_Status = null,
                        //    EmploymentBook_No = null,
                        //    EmploymentBook_Date = DateTime.Today,
                        //    DirectBook_No = null,
                        //    DirectBook_Date = DateTime.Today,
                        //    Nots = null,
                        //    EntryDate = DateTime.Today,
                        //    LastUpdateDate = DateTime.Today,
                        //    DataEntryName = null,
                        //    Image = null,
                        //    PDF = null,
                        //    PersonalId=1

                        // },
                     });
                    context.SaveChanges();
                }

                //Administrative_Orders
                    if (!context.Administrative_Orders.Any())
                {
                    context.Administrative_Orders.AddRange(new List<Administrative_Orders>()
                        {
                            //new Administrative_Orders()
                            //{
                            //   // Admi_id = 1,
                            //   AdministrativeNo = 0,
                            //   OrderNo = 0,
                            //   Administrative_Order_Date = DateTime.Today,
                            //   Type_Of_Order =null,
                            //   Subject=    null,
                            //   Summary =null,
                            //   Nots = null,
                            //   EntryDate = DateTime.Today,
                            //   LadtUpdateDate = DateTime.Today,
                            //   DataEntryName = null,
                            //   Image = null,
                            //   PDF = null,
                            //   PersonalId= 1,
                            //   Employee_id=1
                            // },

                         });
                    context.SaveChanges();
                }

               
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}


