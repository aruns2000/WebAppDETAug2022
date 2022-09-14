using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;
using Xunit;
namespace TestProject_ClassLibPizza
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Name = "Veg", Size = PizzaSize.Medium, IsGlutenFree = true };

            PizzaService.Add(p);

            Pizza verify = PizzaService.Get(3);
            Assert.Equal(3, PizzaService.GetAll().Count());
            Assert.NotNull(verify.Id);
        }
       // [Fact]
        //public void Test_DeletePizza()
        //{
            

        //    PizzaService.Delete(3);

        //    Assert.Equal(3, PizzaService.GetAll().Count());

        //}
        //[Fact]
        //public void Test_UpdatePizza()
        //{
        //    Pizza p = new Pizza { Name = "Non", Size = PizzaSize.Medium, IsGlutenFree = true };

        //    PizzaService.Update(p); 

        //    Pizza verify = PizzaService.Get(3);
        //    Assert.Equal(3, PizzaService.GetAll().Count());
        //    Assert.NotNull(verify.Id);
        //}
    }
}