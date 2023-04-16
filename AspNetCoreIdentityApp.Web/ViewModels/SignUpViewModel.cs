using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
            
        }
        public SignUpViewModel(string email, string password, string phoneNumber, string userName)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            UserName = userName;
        }
        [Required(ErrorMessage ="Username field is required.")]
        [Display(Name = "Username :")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email field is required.")]
        [Display(Name ="Email :")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone field is required.")]
        [Display(Name = "Phone :")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password field is required.")]
        [Display(Name = "Password :")]
        public string Password { get; set; }

        [Compare(nameof(Password),ErrorMessage ="Passwords are not matched.")]
        [Display(Name = "Password Confirm :")]
        public string PasswordConfirm { get; set; }






    }
}
