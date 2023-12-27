using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekPub.Validation
{
    internal class ValidationPharmacy
    {

        public int valString(string x)
        {
            int check = 0;

            for (int a = 0; a < x.Length; a++)
            {
                if (!(x[a] >= 'a' && x[a] <= 'z' || x[a] >= 'A' && x[a] <= 'Z' || x[a] == ' '))
                {
                    ;
                }
                else if (x[0] == ' ' || x[x.Length - 1] == ' ')
                {
                    check = 1;
                }
                else if (x[a] == ' ' && x[a + 1] == ' ')
                {
                    check = 1;
                }
            }
            return check;
        }



        public int valName(string x)
        {
            int check = 0;

            for (int a = 0; a < x.Length; a++)
            {
                if (!(x[a] >= 'a' && x[a] <= 'z' || x[a] >= 'A' && x[a] <= 'Z' || x[a] == ' '))
                {
                    check = 1;
                }

                else if (x[a] == '/' || x[a]=='?' || x[a] == '*' || x[a] == '.' || x[a] == ',')
                {
                    check = 1;
                }
                else if (x[0] == ' ' || x[x.Length - 1] == ' ')
                {
                    check = 1;
                }
                else if (x[a] == ' ' && x[a + 1] == ' ')
                {
                    check = 1;
                }
            }
            return check;
        }


        public int valPrice(string x)
        {
            int checkeds = 0;
            for (int a = 0; a < x.Length; a++)
            {
                if (x[0] == '0')
                {
                    checkeds = 1;
                }
                if (!(x[a] >= '0' && x[a] <= '9'))
                {
                    checkeds = 1;
                }
            }

            return checkeds;
        }


        public int valStock(string x)
        {
            int checkeds = 0;
            for (int a = 0; a < x.Length; a++)
            {
                if (x[0] == '0')
                {
                    checkeds = 1;
                }
                if (!(x[a] >= '0' && x[a] <= '9'))
                {
                    checkeds = 1;
                }
            }

            return checkeds;
        }



    }
}
