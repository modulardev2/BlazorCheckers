using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Client.Data
{
    public class Checker
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public CheckerDirection Direction { get; set; }
        public string Color { get; set; }
    }

    public enum CheckerDirection
	{
        Down, Up, Both
	}
}
