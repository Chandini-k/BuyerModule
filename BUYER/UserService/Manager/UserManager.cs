using BUYERDB.Entity;
using BUYERDB.Repositories;
using System.Threading.Tasks;

namespace UserService.Manager
{
    public interface IUserManager
    {
        Task<bool> BuyerRegister(Buyer buyer);
        Task<Buyer> ValidateBuyer(string uname, string pwd);
    }
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _iuserRepository;
        public UserManager(IUserRepository iuserRepository)
        {
            _iuserRepository = iuserRepository;
        }
        public async Task<bool> BuyerRegister(Buyer buyer)
        {
           return await _iuserRepository.BuyerRegister(buyer);
        }

        public async Task<Buyer> ValidateBuyer(string uname, string pwd)
        {
            return await _iuserRepository.ValidateBuyer(uname, pwd);
        }

    }
}
