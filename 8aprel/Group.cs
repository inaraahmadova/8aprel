using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8aprel
{
    internal class Group
    {
        private static int groupCount = 0;

        public static Group[] Groups { get;  set; }
        public static int GroupCount { get => groupCount; }

        public int GroupId { get;  set; }
        public string GroupName { get; set; }
        public Student[] Students { get;  set; }

        public Group(string groupName)
        {
            GroupId = ++groupCount;
            GroupName = groupName;
            Students = new Student[0];
            AddGroup(this);
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"Group ID: {GroupId}, Group Name: {GroupName}");
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }
        public Student GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.StudentId == id)
                    return student;
            }
            return null; 
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            Students.Add(student);
        }

        public void Search(string searchString)
        {
            foreach (var student in Students)
            {
                if (student.Name == searchString || student.Surname == searchString)
                {
                    student.GetInfo();
                }
            }
        }


        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }

        public override string ToString()
        {
            return $"Group ID: {GroupId}, Group Name: {GroupName},  Group Count: {GroupCount}";
        }

        private static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }
        public static void RemoveGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group.GroupId == id)
                {
                    continue;
                    Group[] NewGroups = new Group[Groups.Length - 1];
                    Groups= NewGroups;
                }
            }
        }

        public static Group GetGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group.GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }
    }
}

