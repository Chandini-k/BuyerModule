using BUYERDB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUYERDB.Repositories
{
   public interface IBuyerRepository
    {
        void EditProfile(Buyer buyer);
        Buyer GetProfile(int bid);
    }
}
