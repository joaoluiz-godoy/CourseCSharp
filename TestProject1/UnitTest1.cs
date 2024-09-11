namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            int number1 = 5;
            int number2 = 3;

            // Act
            int result = calculator.Add(number1, number2);

            // Assert
            Assert.Equal(8, result);

            // Testando números negativos
            Assert.Equal(-2, calculator.Add(-5, 3));

            // Testando número positivo e zero
            Assert.Equal(5, calculator.Add(5, 0));

            // Testando números grandes, DARÁ ERRO!!
            //Assert.Equal(3000000, calculator.Add(1000000, 1));
        }
    }
}
