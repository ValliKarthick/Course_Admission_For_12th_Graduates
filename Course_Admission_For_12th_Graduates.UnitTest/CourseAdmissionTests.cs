using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Course_Admission_For_12th_Graduates.UnitTest
{
    [TestFixture]
    public class CourseAdmissionTests
    {
        private MethodInfo testingMethod;
        private object SUT;

        [SetUp]
        public void Initialize()
        {
            Assembly assembly = Assembly.Load("Course_Admission_For_12th_Graduates");
            SUT = assembly.CreateInstance(assembly.GetTypes().Where(type => type.Name == "DiscountVerification").FirstOrDefault()?.FullName,
                false, BindingFlags.CreateInstance, null, null, null, null);
            testingMethod = SUT.GetType().GetMethod("CalculateDiscount");
        }

        [Test]
        public void Check_Discount_When_Percentage_Is_Less_Than_50()
        {
            int studentTotalPercentageinTwelthGrade = 48;
            Assert.AreEqual(0, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
        [Test]
        public void Check_Discount_When_Percentage_Is_50()
        {
            int studentTotalPercentageinTwelthGrade = 50;
            Assert.AreEqual(0, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }

        [Test]
        public void Check_Discount_When_Percentage_Is_Between_50_To_60()
        {
            int studentTotalPercentageinTwelthGrade = 55;
            Assert.AreEqual(1500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
        [Test]
        public void Check_Discount_When_Percentage_Is_60()
        {
            int studentTotalPercentageinTwelthGrade = 60;
            Assert.AreEqual(1500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }

        [Test]
        public void Check_Discount_When_Percentage_Is_Between_60_To_75()
        {
            int studentTotalPercentageinTwelthGrade = 66;
            Assert.AreEqual(2500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
        [Test]
        public void Check_Discount_When_Percentage_Is_75()
        {
            int studentTotalPercentageinTwelthGrade = 75;
            Assert.AreEqual(2500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }

        [Test]
        public void Check_Discount_When_Percentage_Is_Between_75_To_90()
        {
            int studentTotalPercentageinTwelthGrade = 80;
            Assert.AreEqual(3500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
        [Test]

        public void Check_Discount_When_Percentage_Is_90()
        {
            int studentTotalPercentageinTwelthGrade = 90;
            Assert.AreEqual(3500, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }

        [Test]
        public void Check_Discount_When_Percentage_Is_Between_90_To_100()
        {
            int studentTotalPercentageinTwelthGrade = 95;
            Assert.AreEqual(5000, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
        [Test]
        public void Check_Discount_When_Percentage_Is_100()
        {
            int studentTotalPercentageinTwelthGrade = 100;
            Assert.AreEqual(5000, testingMethod.Invoke(SUT, new object[] { studentTotalPercentageinTwelthGrade }));
        }
    }
}
