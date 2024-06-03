using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LoginFormModel
{
    [Display(Prompt = "Enter your email address", Name = "Email")]
    public string Email { get; set; }

    [Display(Prompt = "Enter your password", Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
