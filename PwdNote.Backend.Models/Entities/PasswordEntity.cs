using System;

namespace PwdNote.Backend.Models.Entities
{
    public class PasswordEntity : PasswordBase
    {
        public int Id { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
