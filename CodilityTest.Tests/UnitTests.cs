using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTest.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void deve_retornar_5_como_quantidade_de_distintos()
        {
            var A = new int[6];
            A[0] = -5;
            A[1] = -3;
            A[2] = -1;
            A[3] = 0;
            A[4] = 3;
            A[5] = 6;

            var ret = Test.absDistinct(A);

            Assert.AreEqual(5, ret);
        }

        [TestMethod]
        public void deve_retornar_0_como_quantidade_de_distintos()
        {
            var A = new int[2];
            A[0] = 0;
            A[1] = -100;

            var ret = Test.absDistinct(A);
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void deve_retornar_0_como_menor_distancia()
        {
            var A = new int[8];
            A[0] = 0;
            A[1] = 3;
            A[2] = 3;
            A[3] = 7;
            A[4] = 5;
            A[5] = 3;
            A[6] = 11;
            A[7] = 1;

            var ret = Test.adjacent_points_min_distance(A);
            Assert.AreEqual(0, ret);

        }
    }
}
