using System.Collections.Generic;
using System.Threading.Tasks;
using PwdNote.Backend.Models.Entities;

namespace PwdNote.Backend.Services
{
    public interface IPasswordService
    {
        public Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset);

        public Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset, string keyword);

        public void AddPassword(PasswordEntity passwordItem);

        public PasswordEntity UpdatePassword(int originalId, PasswordEntity newPasswordItem);

        public void RemovePassword(int id);

    }
}
