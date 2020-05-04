using BUYERDB.Entity;
using BUYERDB.Repositories;
using Moq;
using NUnit.Framework;
using System;

namespace TestProject
{
    [TestFixture]
    public class TestUserRepository
    {
        IUserRepository userRepository;
        [SetUp]
        public void SetUp()
        {
            userRepository = new UserRepository(new BuyerContext());
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test Case run sucessfully");
        }
        /// <summary>
        /// Testing register buyer
        /// </summary>
        [Test]
        [TestCase(4526,"suma","abcdefg@","suma@gmail.com","9352678295")]
        [TestCase(3252, "aamani", "aamani@", "ammu@gmail.com", "9352623495")]
        [TestCase(3632, "divya", "abcdefg@", "divya@gmail.com", "9452623495")]
        [Description("Test Register()")]
        public void TestRegister(int bid,string username,string password,string email,string mobileno)
        {
            var Datetime = System.DateTime.Now;
            var buyer = new Buyer { Bid = bid, Username = username,Password=password,Email=email,Mobileno=mobileno,Datetime=Datetime };
            userRepository.BuyerRegister(buyer);
            var mock = new Mock<IUserRepository>();
            mock.Setup(x => x.BuyerRegister(buyer));
            var result = userRepository.ValidateBuyer(username,password);
            Assert.NotNull(result);
        }
        [Test]
        [Description("Test BuyerLogin()")]
        public void TestBuyerLogin()
        {
            var result = userRepository.ValidateBuyer("chandus", "abcdefg@");
            Assert.NotNull(result);
        }
    }
}
