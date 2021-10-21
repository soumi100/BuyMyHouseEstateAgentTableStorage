using System;

namespace Domain
{
    public class Applicant
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Income { get; set; }

        public string Info { get; set; }

        public Applicant()
        {

        }
        public Applicant(string fullName, string info)
        {
            FullName = fullName;
            Info = info;
            Income = 3500;
        }
        public override string ToString()
        {
            return $"Dear {FullName} Based on your income {Income.ToString()} we have the following options : ";
        }
    }
}
