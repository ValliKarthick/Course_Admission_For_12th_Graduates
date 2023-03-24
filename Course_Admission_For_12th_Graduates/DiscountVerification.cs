namespace Course_Admission_For_12th_Graduates
{
    public class DiscountVerification
    {
        StudentDetail studentDetail = new StudentDetail();

        public int CalculateDiscount(int studentTotalPercentageinTwelthGrade)
        {
            if (studentTotalPercentageinTwelthGrade > 50 && studentTotalPercentageinTwelthGrade <= 60)
                return 1500;
            else if (studentTotalPercentageinTwelthGrade > 60 && studentTotalPercentageinTwelthGrade <= 75)
                return 2500;
            else if (studentTotalPercentageinTwelthGrade > 75 && studentTotalPercentageinTwelthGrade <= 90)
                return 3500;
            else if (studentTotalPercentageinTwelthGrade > 90 && studentTotalPercentageinTwelthGrade <= 100)
                return 5000;
            else return 0;
        }
    }
}
