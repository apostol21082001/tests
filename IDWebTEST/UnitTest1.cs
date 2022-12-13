namespace IDWebTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
               int result = 2 + 2;
               Assert.AreEqual(result, 4);
        }
          [Test]
          public void Test2()
          {
               int number;
               number = 15;  
               
               Assert.IsTrue( number%2 != 0);
          }
          [Test]
          public void Test3()
          {
               int limit = 15;
               int[] series = new int[1];
               Array.Resize(ref series, limit);

               series[0] = 0;
               series[1] = 1;

               for (int i = 2; i < limit; i++)
                    series[i] = series[i - 1] + series[i - 2];

               Assert.IsTrue(series.Contains(5));
          }
          [Test]
          public void Test4()
          {
               int a = 15;
               int b = 20;
               int c = 2;
               
               Assert.IsFalse(a > b && a > c);
          }
          [Test]
          public void Test5()
          {
               int a = 10;
               int b = 20 * 5 / (4 * 2) + a * a;

               Assert.Greater(b, 100);
          }
          
         
     }
}