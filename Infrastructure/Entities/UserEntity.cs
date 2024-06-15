using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string SecurityKey { get; set; } = null!;
    public string? Phone { get; set; }
    public string? Biography { get; set; }
    public DateTime? Created {  get; set; }
    public DateTime? Updated { get; set; }
    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}
