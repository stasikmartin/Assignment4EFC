using System.ComponentModel.DataAnnotations;

namespace AdultsWebApi.Model
{
    public class Adult
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        [Key]
        public int id { get; set; }
        public string hairColor { get; set; }
        public string eyeColor { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public string jobTitle { set; get; }
        public string sex { get; set; }
    }
}