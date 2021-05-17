using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdNote.Backend.Models
{
    public class PasswordBase
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
    }
}
