using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Course_Admission_For_12th_Graduates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> courses = new Dictionary<int, string>();
            courses.Add(1, "Classical Physics");
            courses.Add(2, "Bio Chemistry");
            courses.Add(3, "Psychology");
            courses.Add(4, "Geo Science");
            courses.Add(5, "Advanced Maths");

            StudentDetail studentDetail = new StudentDetail();

            Console.WriteLine("Enter Student Name: ");
            studentDetail.StudentName = Console.ReadLine();

        GetPercentage:
            Console.WriteLine("Enter Student's 12th Percentage: ");
            studentDetail.StudentTotalPercentageinTwelthGrade = Convert.ToInt32(Console.ReadLine());
            if (studentDetail.StudentTotalPercentageinTwelthGrade < 0 || studentDetail.StudentTotalPercentageinTwelthGrade > 100)
            {
                Console.WriteLine("InValid Percentage");
                goto GetPercentage;
            }

        GetCourse:
            Console.WriteLine("Choose Student's Preferred Course from the List Below: ");
            foreach (KeyValuePair<int, string> course in courses)
            {
                Console.WriteLine($"{course.Key}.{course.Value}");
            }
            studentDetail.PreferredCourse = int.Parse(Console.ReadLine());
            Regex patternforOptions = new Regex(@"^[1-5]{1}$");
            if (!patternforOptions.IsMatch(studentDetail.PreferredCourse.ToString()))
            {
                Console.WriteLine("InValid Option");
                goto GetCourse;
            }

            DiscountVerification discountVerification = new DiscountVerification();
            studentDetail.DiscountAvailed = discountVerification.CalculateDiscount(studentDetail.StudentTotalPercentageinTwelthGrade);

            Console.WriteLine("----------");
            System.Random random = new Random();
            Console.WriteLine("Dear " +studentDetail.StudentName +",");
            Console.WriteLine("Your admission for " +courses[studentDetail.PreferredCourse] +" is confirmed.");
            Console.WriteLine("Admission Id - " + random.Next());
            if (studentDetail.DiscountAvailed != 0)
                Console.WriteLine("Congratulations! Your have availed Rs." + studentDetail.DiscountAvailed + "/- as discount based on your 12th Percentage.");
            Console.WriteLine("----------");
            Console.ReadLine();
        }
    }
}
