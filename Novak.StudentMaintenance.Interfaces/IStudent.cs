using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.Interfaces
{
    public interface IStudent
    {
        // Private property signatures
        double Gpa { get; set; }
        string Id { get; set; }

        void SaveStudent();
        bool Enroll();
    }
}
