using System.ComponentModel.DataAnnotations.Schema;

namespace Pagination.Entities;

[Table("People", Schema = "dbo")]
public class PeopleEntity
{
    public  int Id { get; set; }    
    public string? Name { get; set; }
    public int Age { get; set; }
}
