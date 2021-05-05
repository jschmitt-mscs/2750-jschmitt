using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Course
    {
        public Course(int id, string CourseNum, string courseTitle, short credits, Department department)
        {
            this.Id = id;
            this.CourseNum = CourseNum;
            this.CourseTitle = courseTitle;
            this.Credits = credits;
            this.Department = department;
            this.Department.Courses.Add(this);
            this.Sections = new HashSet<Section>();
        }

        public Section FindSection(int id)
        {
            Section foundSection = null;
            foreach (Section s in this.Sections)
            {
                if (s.Id == id)
                {
                    foundSection = s;
                    break;
                }
            }
            return foundSection;
        }
    }
}
