using BUYERDB.Entity;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUYERDB.Repositories
{
    public interface IUserRepository
    {
        Task<bool> BuyerRegister(Buyer buyer);
        Task<Buyer> ValidateBuyer(string uname, string pwd);
    }
}
