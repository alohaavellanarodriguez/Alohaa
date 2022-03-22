
using System.ComponentModel.DataAnnotations;

namespace Alohaa.models
{
    public class pogi
    {
        public int ID { get; set; }
        public string Tittle { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; } 
            
    }
}
