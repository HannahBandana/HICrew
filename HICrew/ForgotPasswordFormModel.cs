using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataForm;
using Syncfusion.Maui.Inputs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HICrew
{
    public class ForgotPasswordFormModel
    {
        [Display(Name = "Email for us to contact you")]
        public string Email { get; set; }
    }
}