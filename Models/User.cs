using System.ComponentModel.DataAnnotations;

namespace mrbatri.Models;

public class User
{
    public long Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string FullName { get; set; }
    [Required]
    [MaxLength(100)]
    public string Email { get; set;}
    [DataType(DataType.Date)]
    public DateTime RegistrationDate { get; set; }
}