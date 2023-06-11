#nullable disable
using System.ComponentModel.DataAnnotations;

namespace SteelanceX.Contracts.DataTransferObjects.Authority.Request;
public class LoginRequest
{
    [Required(ErrorMessage = "Please enter username")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
