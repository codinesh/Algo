// using System;
// using Xunit;

// namespace Algo.Solution.Tests;

// public class UnitTest1
// {
//     [Fact]
//     public void TestGreet()
//     {
//         var solution = new Algo.Solution.Solution();
//         var input = "Dinesh";
//         var result = solution.Greet(input);

//         var expected = $"Hello {input}!";
//         Assert.Equal(expected, result);
//     }

//     [Theory]
//     [InlineData(1, 2)]
//     [InlineData(0, 2)]
//     public void TestAdd(int a, int b)
//     {
//         var solution = new Algo.Solution.Solution();
//         var result = solution.Add(a, b);

//         var expected = a + b;
//         Assert.Equal(expected, result);
//     }


//     [Theory]
//     [InlineData(-1, 8)]
//     public void ShouldThrowExceptionForNegativeNumbers(int a, int b)
//     {
//         var solution = new Algo.Solution.Solution();

//         Assert.Throws<ArgumentException>(() => solution.Add(a, b));
//     }
// }