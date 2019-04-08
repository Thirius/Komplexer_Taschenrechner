using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerTaschenrechner.Client
{
    public class describeComplexNumber:ComplexNumber
    {
        private int id;
        private string description;

        public describeComplexNumber(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}
