using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elect
{
    delegate int ElectionDelegate();
    class Election
    {
        public event ElectionDelegate ElectionEvent;
        public int OnElection()
        {
            if(ElectionEvent!=null)
            {
                return ElectionEvent();
            }
            throw new NullReferenceException();
        }

    }
}
