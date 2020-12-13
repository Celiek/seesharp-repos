using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Members
{
    class Members
    {

        public string IsCorrect(string login  , string haslo)
        {
            string poprawnylogin = "celiek";
            string poprawnyhaslo = "1234";

            int correcthaslo = String.Compare(poprawnyhaslo, haslo);
            int correctlogin = String.Compare(poprawnylogin, login);

            if(correcthaslo == 0 && correctlogin  ==  0)
            {
                return "TAK";
            }
            else
            {
               return  "Nie";
            }
            
            
          //  return "Error";
        }
    }
}
