using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
   public class Doctor
    {
        public Doctor()
        {
            
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SSN { get; set; }
        public string specializition {  get; set; }
        public Guid ID { get; } = Guid.NewGuid();

    }
}
