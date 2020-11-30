using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2
{
    class Department
    {
        public string Name { get; set; }
        public string Id { get; set; }
        ArrayList facultyMembers;
        public Department(string name, string id)
        {
            facultyMembers = new ArrayList();
            Name = name;
            Id = id;
        }
        public void AddFaculty(params Faculty[] faculty)
        {
            foreach (Faculty f in faculty)
            {
                facultyMembers.Add(f);
            }
        }
        public Faculty SearchFaculty(string id)
        {
            Faculty temp = null;
            foreach (Faculty f in facultyMembers)
            {
                if (f.Id.Equals(id))
                {
                    temp = f;
                }
            }
            return temp;
        }
        public void DeleteFaculty(Faculty f)
        {
            facultyMembers.Remove(f);
        }
        public void ShowAllFaculty()
        {
            foreach (Faculty f in facultyMembers)
            {
                f.ShowInfo();
            }
        }

    }
}
