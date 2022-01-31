using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab4_.Models
{
    public class Province
    {
        [Key]
        [MaxLength(2)]
        public string? provCode { get; set; }
        public string? provName { get; set; }

        public List<City>? cities { get; set; }

    }
}