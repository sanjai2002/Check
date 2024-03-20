using Assessment_KT;

namespace Calculatortest
{
    public class Tests
    {
        [Test]
        public void Add_Testcase_1()
        {
            Calculator ob= new Calculator();
            var case1 = ob.Add(1, 5);
            Console.WriteLine(case1);
            Assert.That(case1, Is.EqualTo(6));
        }


        [Test]
        public void Add_Testcase_2()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Add(1, 7);
            Console.WriteLine(case1);
            Assert.That(case1, Is.Not.EqualTo(6));
        }


        [Test]
        public void Sub_Testcase_1()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Subtract(10, 7);
            Console.WriteLine(case1);
            Assert.That(case1, Is.EqualTo(3));
        }

        [Test]
        public void Sub_Testcase_2()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Subtract(15, 7);
            Console.WriteLine(case1);
            Assert.That(case1, Is.Not.EqualTo(10));
        }


        [Test]
        public void Multiply_Testcase_1()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Multiply(8, 7);
            Console.WriteLine(case1);
            Assert.That(case1, Is.EqualTo(56));
        }

        [Test]
        public void Multiply_Testcase_2()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Multiply(5, 9);
            Console.WriteLine(case1);
            Assert.That(case1, Is.Not.EqualTo(67));
        }

        [Test]
        public void Divide_Testcase_1()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Divide(70, 7);
            Console.WriteLine(case1);
            Assert.That(case1, Is.EqualTo(10));
        }

        [Test]
        public void Divide_Testcase_2()
        {
            Calculator ob = new Calculator();
            var case1 = ob.Divide(125, 5);
            Console.WriteLine(case1);
            Assert.That(case1, Is.Not.EqualTo(67));
        }



    }
}