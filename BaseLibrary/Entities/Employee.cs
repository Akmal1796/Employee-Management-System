namespace BaseLibrary.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CivilID { get; set; }

        public string? FileNumber { get; set; }

        public string? FullName { get; set; }

        public string? JobName { get; set; }

        public string? Address { get; set; }

        public string? TelephoneNumber { get; set; }

        public string? Photo { get; set;}

        public string? Other { get; set; }

        //Relationship : Many to One
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentID { get; set; }

        public Department? Department { get; set; }
        public int DepartmentID { get; set; }

        public Branch? Branch { get; set; }
        public int BranchID { get; set; }

        public Town? Town { get; set; }
        public int TownID { get; set; }
    }
}
