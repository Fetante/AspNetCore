using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCSigIn.Models;

public class AccountDetailsAddressInfoModel
{
    [Display(Name = "Addressline", Prompt = "Enter your Address", Order = 0)]
    [Required(ErrorMessage = "Invalid Address")]
    public string Addressline_1 { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your Address 2", Order = 1)]
    public string? Addressline_2 { get; set; }

    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 0)]
    [Required(ErrorMessage = "Postal code is required")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City", Prompt = "Enter your City", Order = 1)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
