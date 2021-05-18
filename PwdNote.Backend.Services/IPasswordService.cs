using System.Collections.Generic;
using System.Threading.Tasks;
using PwdNote.Backend.Models.Entities;

namespace PwdNote.Backend.Services
{
    public interface IPasswordService
    {
        public Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset);

        public Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset, string keyword);

        public PasswordEntity AddPassword(PasswordEntity passwordItem);

        public PasswordEntity UpdatePassword(int originalId, PasswordEntity newPasswordItem);

        public bool RemovePassword(int id);

    }
}
