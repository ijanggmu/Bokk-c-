using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BookOOP_C_
{
    public class BookList
    {
        private List<Subject> _subjects = new List<Subject>() {
        new Subject("OOP ","CSC1000 "),
        new Subject("DSA ","CSC1001 "),
    };
    public void AddBook(Subject subject)

        {
            _subjects.Add(subject);
        }

        public void isValid(Subject subject)
        {
            if (subject._sCode.Length == 7)
            {
                var firstThree = (Regex.IsMatch(subject._sCode.Substring(0, 3), @"^[a-zA-Z]+$"));
                if (!firstThree)
                {
                    Console.WriteLine($"First three Character must be Alphabet");
                }
                var lastFour = (Regex.IsMatch(subject._sCode[^4..], @"^[0-9]+$"));
                if (!lastFour)
                {
                    Console.WriteLine($"Last Four Character must be Numeric");
                }
                codeExists(subject);

            }

            else
                Console.WriteLine($"Length of the subject code must be 7 charater. You have entered subject code: {subject._sCode}  ");

        }
        public void codeExists(Subject subject)
        {
            var checks = 1;
            for (int i = 0; i < _subjects.Count; i++)
            {
                
                var check = String.Equals(_subjects[i]._sCode, subject._sCode);
                Console.WriteLine(_subjects[i]._sCode,subject._sCode);
                Console.WriteLine(_subjects.Count);
                Console.WriteLine(check);
                if (check)
                {
                    checks = 1;
                }
                else
                {
                    checks = 0;
                }
            }
                if (checks == 0)
                {
                    _subjects.Add(subject);
                }
                if(checks==1)
                {
                    Console.WriteLine("already Exist");
                }

            }
                
            
        public void DisplayBook()
        {
            Console.WriteLine($"| Book Name | | Book Code |");
            foreach (var subject in _subjects)
            {
                Console.WriteLine($" {subject._sName} | | {subject._sCode} ");
            }
        }
    }
}
