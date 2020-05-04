using BUYERDB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUYERDB.Repositories
{
    public interface IItemRepository
    {
        List<Items> Search(string itemname);
        List<Items> SearchItemByCategory(string cname);
        List<Items> SearchItemBySubCategory(string suname);
        void BuyItem(Purchasehistory purchase);
        List<Purchasehistory> Purchase(int bid);
        List<Category> GetCategories();
        List<SubCategory> GetSubCategories(int cid);
        List<Items> GetItems();
        void AddToCart(Cart cart);
        int GetCount(int bid);
        bool CheckCartItem(int buyerid, int itemid);
        List<Cart> GetCarts(string bid);
        void DeleteCart(string cartid);
        Purchasehistory GetpurchaseHistory(int id);
        Cart GetCartItem(int cartid);
        List<Items> Items(int price, int price1);
    }
}
