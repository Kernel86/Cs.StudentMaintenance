using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.CustomExceptions
{
    public class FileWasNotFoundException : System.Exception
    {
    // Constructors
        public FileWasNotFoundException()
        {
        }

        public FileWasNotFoundException(string message) : base(message)
        {
        }
    }
}
