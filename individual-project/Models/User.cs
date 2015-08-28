using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Individual_project.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<MFTFormSubmission> MFTForms { get; set; }
    }
}