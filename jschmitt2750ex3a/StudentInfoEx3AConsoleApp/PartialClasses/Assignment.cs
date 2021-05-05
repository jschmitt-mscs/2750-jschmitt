using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Assignment
    {
        public Assignment(int id, string assign, string description,
            short maxPoints, DateTime dueDate, AssignmentTypesEnum assignmentType,
            Section section)
        {
            this.Id = id;
            this.Assign = assign;
            this.Description = description;
            this.MaxPoints = maxPoints;
            this.DueDate = dueDate;
            this.Type = assignmentType;
            this.Section = section;
            this.AssignmentGrades = new HashSet<AssignmentGrade>();
            this.Section.Assignments.Add(this);
           

        }

        public AssignmentGrade FindAssignmentGrade(int studentId)
        {
            AssignmentGrade foundAssignmentGrade = null;

            foreach(AssignmentGrade ag in this.AssignmentGrades)
            {
                if(ag.Enrollment.Student.Id == studentId)
                {
                    foundAssignmentGrade = ag;
                    break;
                }
            }

            return foundAssignmentGrade;
        }
    }
}
