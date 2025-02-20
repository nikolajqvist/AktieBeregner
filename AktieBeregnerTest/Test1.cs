using AktieBeregner;

namespace AktieBeregnerTest
{
    [TestClass]
    public sealed class Test1
    {
        [DataRow(100, 10000)]
        [DataRow(10, 100000)]
        [DataRow(1, 8)]
        [TestMethod]
        public void ReturnValue_Test_NotApproved(int expectedValue, int value)
        {
            var share = new Share("Novo", value, 2, 8);

            var result = share.ReturnValue();

            Assert.AreNotEqual(result, expectedValue);
        }
        [DataRow("Novo", 140, 200, 10, 600)]
        [DataRow("DanskeBank", 150, 140, 25, -250)]
        [DataRow("Paul petersen", 97, 85, 9, -108)]
        [TestMethod]
        public void ReturnValueTest_Approve(string name, int buyprice, int sellprice, int amount
            , int expectedresult)
        {
            var s1 = new Share(name, amount, buyprice, sellprice);

            var reusult = s1.ReturnValue();

            Assert.AreEqual(reusult, expectedresult);
        }
    }
}
