using PwdNote.Backend.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PwdNote.Backend.Data;

namespace PwdNote.Backend.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly ProjDbContext _context;

        public PasswordService(ProjDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddPassword(PasswordEntity passwordItem)
        {
            if (passwordItem == null) throw new ArgumentNullException(nameof(passwordItem));

            _context.Passwords.Add(passwordItem);
        }

        public async Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset) =>
            await _context.Passwords.Take(limit).Skip(offset).ToListAsync();

        public async Task<IList<PasswordEntity>> GetPasswordList(int limit, int offset, string keyword) => 
            await _context.Passwords
                .Where(it => 
                    keyword.Split().Any(word=> 
                        it.Name.Contains(word) || it.UserName.Contains(word)
                    ))
                .Take(limit)
                .Skip(offset)
                .ToListAsync();

        public bool RemovePassword(int id)
        {
            var itemToRemove = _context.Passwords.FirstOrDefault(it => it.Id == id);

            if (itemToRemove == null) return false;

            _context.Passwords.Remove(itemToRemove);

            return true;
        }

        public PasswordEntity UpdatePassword(int originalId, PasswordEntity newPasswordItem)
        {
            var originalPasswordItem = _context.Passwords.FirstOrDefault(it => it.Id == originalId);

            if (originalPasswordItem == null)
            {
                AddPassword(newPasswordItem);
            }

            _context.Update(originalPasswordItem);
            
            return newPasswordItem;
        }
    }
}
