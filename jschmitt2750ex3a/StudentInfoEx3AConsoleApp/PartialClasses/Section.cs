using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Section
    {
        public Section(int id, short capacity, Course course, Term term)
        {
            this.Id = id;
            this.Capacity = capacity;
            this.Course = course;
            this.Term = term;
            this.Course.Sections.Add(this);
            this.Term.Sections.Add(this);
            this.Enrollments = new HashSet<Enrollment>();
            this.Assignments = new HashSet<Assignment>();

        }

        public Enrollment FindEnrollment(int studentId)
        {
            Enrollment foundEnrollment = null;

            foreach(Enrollment e in this.Enrollments)
            {
                if(e.Student.Id == studentId)
                {
                    foundEnrollment = e;
                }
            }

            return foundEnrollment;
        }

        public Assignment FindAssignment(string assign)
        {
            Assignment foundAssignment = null;

            foreach(Assignment a in this.Assignments)
            {
                if(a.Assign == assign)
                {
                    foundAssignment = a;
                }
            }

            return foundAssignment;
        }
    }
}
