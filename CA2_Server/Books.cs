using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA2_Server
{
    public class Books
    {
        
        [Required]
        [Key]
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string Review{ get; set; }

        public int price { get; set; }

        public int AuthorID { get; set; }

        
    }

    public class Authors
    {
        [Required]
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }

        [ForeignKey("AuthorID")]
        public Books Books { get; set; }

    }
}


/*public IEnumerable<Authors> GetAuthor()
{
    return _context.Author.Include(c => c.Books);
}*/