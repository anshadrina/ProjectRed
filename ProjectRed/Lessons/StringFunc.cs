using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed
{
    class StringFunc
    {
        public string ChangeSubstring(string originalString, string substring, string replaceTo)
        {
            return originalString.Replace(substring, replaceTo);
        }

        public string[] NormalizeLogins(string logins)
        {
            logins = logins.ToLower();
            return logins.Split(",");
        }
       
    }
}
