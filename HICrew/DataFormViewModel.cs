namespace HICrew
{
    /// <summary>
    /// Represents the view model class for data form.
    /// </summary>
    public class DataFormViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFormViewModel" /> class.
        /// </summary>
        public DataFormViewModel()
        {
            this.LoginFormModel = new LoginFormModel();
            this.SignupFormModel = new SignupFormModel();
            this.CompanySignupFormModel = new CompanySignupFormModel();
            this.ForgotPasswordFormModel = new ForgotPasswordFormModel();
        }

        /// <summary>
        /// Gets or sets the login form model.
        /// </summary>
        public LoginFormModel LoginFormModel { get; set; }

        public SignupFormModel SignupFormModel { get; set; }

        public CompanySignupFormModel CompanySignupFormModel { get; set; }

        public ForgotPasswordFormModel ForgotPasswordFormModel { get; set; }
    }
}
