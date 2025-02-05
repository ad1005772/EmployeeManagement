[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
namespace EmployeeManagement
{
    [TestClass]
    public class CalculatePayTests
    {
        [TestMethod]
        public void FullTimeEmployee_CalculatePay_ShouldReturn_BaseSalaryPlusAnnualBonus()
        {
            //Arrange
            var fullTimeEmployee = new FullTimeEmployee(123, "Karen", "HR", 50000, 213.59);
            var expectedPayCalculation = 50000 + 213.59;

            //Act & Assert
            Assert.AreEqual(CalculatePay, expectedPayCalculation);
    }
}