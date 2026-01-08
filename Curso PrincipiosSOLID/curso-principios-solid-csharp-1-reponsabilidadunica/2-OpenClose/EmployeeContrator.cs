namespace OpenClose
{
    public class EmployeeContrator:Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeContrator(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}