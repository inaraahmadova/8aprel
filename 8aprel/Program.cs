namespace _8aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group("Group 1");
            Group group2 = new Group("Group 2");

            Student student1 = new Student("inara", "ahmadova");
            Student student2 = new Student("salala", "aliyeva");
            Student student3 = new Student("fatima", "abbasova");

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group2.AddStudent(student3);

            group1.GetGroupInfo();
            group2.GetGroupInfo();
           
            Console.WriteLine("Student  ID 1:");
            Student student = group1.GetStudent(1);
                student.GetInfo();
            
            Group.RemoveGroup(2);
        }
    }
}
