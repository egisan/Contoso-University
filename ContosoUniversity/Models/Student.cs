using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // I must use the convention for ID as below
        // so Entity Framework understand that is the Key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Below are the Navigation properties which allow me 
        // through the Bridge table (Enrollment) to reach the
        // Course Class properties!!
        // Since the relation Student-->Enrollment is 1-to-many
        // I use 'ICollection<Enrollment>'.
        // Note: 'virtual' is used by EF to understand that below 
        // is a Navigation property!!

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}