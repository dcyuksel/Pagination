using System.ComponentModel.DataAnnotations.Schema;

namespace Pagination.Entities;

[Table("Logs", Schema = "dbo")]
public class LogEntity
{
    public  long Id { get; set; }    
    public string? UserName { get; set; }
    public string? Severity { get; set; }
    public string? Message { get; set; }
    public DateTime TimeStamp { get; set; }
}
