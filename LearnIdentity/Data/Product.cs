using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnIdentity.Data
{
    [Table("Product")]
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }   
    }
}
