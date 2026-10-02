using System.ComponentModel;
using Drones.Model;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestPizzeriaTooNearPizzeria()
        {
            // Arrange
            int x = 100;
            int y = 100;
            string nom = "pizzaria";
            List<Pizzeria> pizzerias = new List<Pizzeria>();
            List<Charger> chargers = new List<Charger>();
            

            // Act

            for(int i = 0; i < 10;i++) { 
            Pizzeria.RegisterPizzeria(pizzerias,i,chargers);
            }

            // Assert
        }
        public void TestClientTooNearClient()
        {
            // Arrange

            // Act

            // Assert
        }
        public void TestClientOnPizzeria()
        {
            // Arrange

            // Act

            // Assert
        }
        public void TestPizzeriaOnClient()
        {
            // Arrange

            // Act

            // Assert
        }
        public void TestPizzeriaOnCharger()
        {
            // Arrange

            // Act

            // Assert
        }
        public void TestClientOnCharger()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
