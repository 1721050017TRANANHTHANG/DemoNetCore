using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class A
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
    }
}