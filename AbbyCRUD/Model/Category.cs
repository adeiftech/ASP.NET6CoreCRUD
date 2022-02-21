using System.ComponentModel.DataAnnotations;

namespace AbbyCRUD.Model
{
    //creating a table named Category
    public class Category
    {
        //creating table columns for a database file
        [Key] // This is optional except your primary key is not named "Id"
        public int Id { get; set; } //naming "Id" automatically sets your primary key @Entity Framework
        [Required] // setting attrib for Name
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
