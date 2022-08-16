using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    internal class Program
    {

        public delegate bool Predicate(XClass x);

        void LambdaExpression()
        {
            var likelyUsername = "timmy";

            Predicate classwork = (XClass x) =>
            {
                if (x.UserName == likelyUsername)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }
    }
    class XClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string UserName { get; set; }

    }


}
