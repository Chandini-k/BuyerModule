using BUYERDB.Entity;
using System;

namespace BUYERDB.Repositories
{
    class BuyerRepository:IBuyerRepository
    {
        private readonly BuyerContext _context;
        public BuyerRepository(BuyerContext context)
        {
            _context = context;
        }

        public void EditProfile(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Buyer GetProfile(int bid)
        {
            throw new NotImplementedException();
        }
    }
}
