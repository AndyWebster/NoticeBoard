using NoticeBoard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeBoard.Models
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Notes.Any())
            
            {
                DateTime _date = DateTime.Now;
                context.Add
                    (
                        new Note { Id = 1, Title = "Welcome", Content = "Feel free to make a note for all the world to see!", Date = _date }
                    );

                context.SaveChanges();
            }
        }
    }
}
