using SimpleBookCatalog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatalog.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provide title")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please provide author")]
        [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }


        [EnumDataType(typeof(Category),ErrorMessage ="Please choose category")]
        public Category Category { get; set; }
    }
}
