using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace smartsheet
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
