using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elect
{
    class Candidate
    {
        public string Lastname { get; set; }
        public int VoiceCount { get; set; }
        public string Congratulation { get; set; }
        public override string ToString()
        {
            return $"LastName {Lastname}-->{Congratulation}";
        }
    }
}
