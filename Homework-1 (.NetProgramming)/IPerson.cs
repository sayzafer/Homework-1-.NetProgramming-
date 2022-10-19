using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1__.NetProgramming_
{
    public interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
    }
}
