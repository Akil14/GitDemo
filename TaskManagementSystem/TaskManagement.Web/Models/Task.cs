using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Web.Models
{
    public class Task
    {
        [Key]
        public int Id {get; set;}
        public string Title { get; set; } 
        public string Description { get; set; } 
        public DateTime start_Date { get; set;}
        public DateTime end_Date { get; set;}
        public string Priority { get; set;}
        public DateTime Remainder { get; set; }
        public string sort_By { get; set; }


    }
}
