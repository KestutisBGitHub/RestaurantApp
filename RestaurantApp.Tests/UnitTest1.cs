using RestaurantApp;

namespace RestaurantApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrintFoodList()
        {
            var testConsole = new TestConsole();
            var start = new MainApp();
            start.StartApp(testConsole);


        }





    }

}

public class TestConsole : IConsole

{
    public string Output { get; set; }
    public string Input { get; set; }
    public string ReadLine()
    {
        return Input;
    }

    public void WriteLine(string value)
    {
        Output += value;
    }
}