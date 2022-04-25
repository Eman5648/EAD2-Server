using CA2BookServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookServerTest
{
    public static List<Books> B_Data()
    {
        return new List<Books>
        {
            new Books
            {
                BookID = 1,
                BookName = " A Hazard of Hearts",
                Review = "Exellent",
                Genre = "Romance   ",
                price = 15,
                Read = 1
            },
            new Books
            {
                BookID = 1,
                BookName = " A Hazard of Hearts",
                Review = "Exellent",
                Genre = "Romance   ",
                price = 15,
                Read = 1
            },
            new Books
            {
                BookID = 1,
                BookName = " A Hazard of Hearts",
                Review = "Exellent",
                Genre = "Romance   ",
                price = 15,
                Read = 1
            },
            new Books
            {
                BookID = 1,
                BookName = " A Hazard of Hearts",
                Review = "Exellent",
                Genre = "Romance   ",
                price = 15,
                Read = 1
            },
        };
    }
}
