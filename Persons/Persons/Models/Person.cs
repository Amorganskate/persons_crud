namespace Persons.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int age { get; set; }
        public string eye_color { get; set; }
        public string hair_color { get; set; }
    }
}
