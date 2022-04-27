using System;
using System.Collections.Generic;
using System.Text;

namespace BookOOP_C_
{
    public class Subject
    {
        public string _sName { get; set; }
        public string _sCode { get; set; }
        public Subject(string sName,string sCode)
        {
            _sName = sName;
            _sCode = sCode;
        }
    }
}
