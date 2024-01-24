using System.ComponentModel.DataAnnotations;

namespace Contact_us_form.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Phone { get; set; }
        public string MessageText { get; set; }
    }
}
