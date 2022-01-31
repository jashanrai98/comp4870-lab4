using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace lab4_.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        
        public string? cityName { get; set; }
        public int? population { get; set; }
        
        [ForeignKey("provCode")]
        public string? province { get; set; }
    }
}