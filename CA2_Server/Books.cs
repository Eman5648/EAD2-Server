using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA2_Server
{
    public class Books
    {
        [ForeignKey("BookID")]
        [Required]
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }

        public string Description { get; set; }

        public int price { get; set; }

    }

    public class Author 
    {
        [Required]
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

        public int BookID { get; set; }

    }
}
