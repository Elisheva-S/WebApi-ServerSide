namespace Model
{
    public class Department : Base_Model
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public Department(int departmentId, string departmentName, string Desc)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            Description = Desc;
        }
        public Department()
        {

        }
        public Department(string departmentName, string Desc)
        {
            DepartmentName = departmentName;
            Description = Desc;
        }
    }
}
