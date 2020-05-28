using ContentManagementSystem.Infrastructure.Context;
using ContentManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Infrastructure.Seeding
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }
                else
                {
                    context.Pages.AddRange(
                        new Page
                        {
                            Title = "Home",
                            Slug = "home",
                            Content = "home page",
                            Sorting = 0,
                        },
                        new Page
                        {
                            Title = "About Us",
                            Slug = "about-us",
                            Content = "about us page",
                            Sorting = 500,
                        },
                        new Page
                        {
                            Title = "Services",
                            Slug = "services",
                            Content = "services page",
                            Sorting = 500,
                        },
                        new Page
                        {
                            Title = "Contact",
                            Slug = "contact",
                            Content = "contact page",
                            Sorting = 500,
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
