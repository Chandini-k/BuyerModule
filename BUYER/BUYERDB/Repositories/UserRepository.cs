using BUYERDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUYERDB.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly BuyerContext _context;
        public UserRepository(BuyerContext context)
        {
            _context = context;
        }

        public async Task<bool> BuyerRegister(Buyer buyer)
        {
            _context.Buyer.Add(buyer);
            var user=await _context.SaveChangesAsync();
            if(user>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Buyer> ValidateBuyer(string uname, string pwd)
        {

            Buyer b = _context.Buyer.SingleOrDefault(e => e.Username == uname && e.Password == pwd);
            if (b.Username == uname && b.Password == pwd)
            {
                return b;
            }
            else
            {
                Console.WriteLine("not a valid user");
                return b;
            }


        }
    }
}
