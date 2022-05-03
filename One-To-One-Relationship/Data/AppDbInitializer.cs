using Advisor6.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

                // في حال قاعدة البيانات فارغة سوف تعتمد البيانات هذه 

                //Personal
                if (!context.Personal.Any())
                {
                    context.Personal.AddRange(new List<Personal>()
                    {
                        new Personal()
                        {

                            FullName = "مستشار 1",

                            Gender= Gender.ذكر,
                            MarriedStatus = MarriedStatus.اعزب,
                            PhoneNo = null,
                            Email =null,
                            Address = null,
                            BirthDate = null,
                            BornPlace = null,
                            Nots = null,
                            EntryDate = DateTime.Today,
                            LastUpdateDate = DateTime.Today,
                            DataEntryName = null,
                            Image = null,
                            PDF = null
                        },
                        

                         });
                    context.SaveChanges();
                }
                //Employment_info
                if (!context.Employment_info.Any())
                {
                    context.Employment_info.AddRange(new List<Employment_info>()
                    {
                        new Employment_info()
                        {


                            FullName = "مستشار",
                            MainDeptartment = null,
                            SubDeptartment = null,
                            Salary = null,
                            Service_Continuation = Service_Continuation.continuous,
                            Job_Title = null,
                            Job_Status = null,
                            EmploymentBook_No = null,
                            EmploymentBook_Date = DateTime.Today,
                            DirectBook_No = null,
                            DirectBook_Date = DateTime.Today,
                            Nots = null,
                            EntryDate = DateTime.Today,
                            LastUpdateDate = DateTime.Today,
                            DataEntryName = null,
                            Image = null,
                            PDF = null
                            
                         },
                     });
                    context.SaveChanges();
                }

                //Administrative_Orders
                if (!context.Administrative_Orders.Any())
                {
                    context.Administrative_Orders.AddRange(new List<Administrative_Orders>()
                    {
                        new Administrative_Orders()
                        {
                           // Admi_id = 1,
                           AdministrativeNo = 0,
                           OrderNo = 0,
                           Administrative_Order_Date = DateTime.Today,
                           Type_Of_Order =null,
                           Subject=    null,
                           Summary =null,
                           Nots = null,
                           EntryDate = DateTime.Today,
                           LadtUpdateDate = DateTime.Today,
                           DataEntryName = null,
                           Image = null,
                           PDF = null,
                           PersonalId= 1,
                          // Employee_id=1
                         },

                     });
                    context.SaveChanges();
                }
            }
        }
    }
}


