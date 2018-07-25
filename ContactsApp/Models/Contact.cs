using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsApp.Models
{
    public class Contact
    {
        #region Attributes
            public int ContactID { get; set; }

            public string Name { get; set; }

            public string LastName { get; set; }

            public Byte ProfilePic { get; set; }

            public string  Address { get; set; }

            public string Phone { get; set; }

            public string Email { get; set; }
        #endregion
    }
}