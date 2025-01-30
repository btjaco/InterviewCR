using InterviewCR.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonParser jsonParser = new JsonParser();
            jsonParser.LoadMenuItems();
        }
    }
}
