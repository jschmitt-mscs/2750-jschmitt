using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class AssignmentGrade
    {
        public AssignmentGrade(int id, short points, DateTime dateCompleted, 
            Enrollment enrollment, Assignment assignment)
        {

            this.Id = id;
            this.Points = points;
            this.DateCompleted = dateCompleted;
            this.Enrollment = enrollment;
            this.Assignment = assignment;
            this.Enrollment.AssignmentGrades.Add(this);
            this.Assignment.AssignmentGrades.Add(this);
        }
    }
}
