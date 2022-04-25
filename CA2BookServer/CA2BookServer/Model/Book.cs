using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA2BookServer.Model
{
    public class Books
    {
        [ForeignKey("BookID")]
        [Required]
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }

        public string Review { get; set; }

        public string Genre { get; set; }

        public int price { get; set; }

        public int Read { get; set; }

    }

    public class Authors
    {
        [Required]
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int Age { get; set; }
        public string DOB { get; set; }

    }
}
