using System.ComponentModel.DataAnnotations;

namespace mrbatri.Models;

public class User
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set;}
    [DataType(DataType.Date)]
    public DateTime RegistrationDate { get; set; }
}