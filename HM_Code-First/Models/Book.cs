using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Code_First.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        public decimal Price { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int PublisherId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<Genre> Genre { get; set; }
    }
}
