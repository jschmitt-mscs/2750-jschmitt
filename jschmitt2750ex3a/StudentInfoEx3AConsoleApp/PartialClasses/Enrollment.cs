using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoEx3AConsoleApp
{
    public partial class Enrollment
    {
        public Enrollment(int Id, GradeTypesEnum gradeType, 
            GradesEnum grade, Student student, Section section)
        {
            this.Id = Id;
            this.GradeType = gradeType;
            this.Grade = grade;
            this.Student = student;
            this.Section = section;
            this.AssignmentGrades = new HashSet<AssignmentGrade>();

            this.Section.Enrollments.Add(this);
            this.Student.Enrollments.Add(this);

        }

        public AssignmentGrade FindAssignmentGrade(string assign)
        {
            AssignmentGrade foundAssignmentGrade = null;
            foreach(AssignmentGrade ag in this.AssignmentGrades)
            {
                if(ag.Assignment.Assign == assign)
                {
                    foundAssignmentGrade = ag;
                    break;

                }
            }
            return foundAssignmentGrade;
        }

        public int CalcTotalPoints()
        {
            int totalPoints = 0;

            foreach(AssignmentGrade ag in this.AssignmentGrades)
            {
                totalPoints += ag.Points;
            }

            return totalPoints;
        }

        public GradesEnum CalcGrade()
        {
            GradesEnum grade = GradesEnum.Z;
            int totalPoints = this.CalcTotalPoints();

            if(totalPoints >= 90)
            {
                return GradesEnum.A;
            } else if(totalPoints >= 80)
            {
                return GradesEnum.B;
            } else if(totalPoints >= 70)
            {
                return GradesEnum.C;
            } else if(totalPoints >= 60)
            {
                return GradesEnum.D;
            } else
            {
                return GradesEnum.F;
            }

            return grade;
        }
    }
}
