using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_proyect
{
    public class estudante : IComparable
    {
        public string nombre { get; set; }
        public string Estado { get; set; }
        public string blnombre { get; set; }
        public string blestudio { get; set; }
        public string blnacimiento { get; set; }
        public string blvalidez { get; set; }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
