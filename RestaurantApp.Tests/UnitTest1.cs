namespace RestaurantApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // Data

        var tableList = new List<Tables>()
            {
                new Tables("1", 2, true),
                new Tables("2", 2, true),
                new Tables("3", 4, true),
                new Tables("4", 4, true),
                new Tables("5", 8, true),
                new Tables("6", 12, true),
            };

    }
}