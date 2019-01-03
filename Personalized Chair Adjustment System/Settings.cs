using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Chair_Adjustment_System
{
    class Settings
    {
        /*
    * A class of globally referred variables.
    */
        internal static string Username;
        internal static decimal ID_Number;
        internal static string name;
        internal static string connectionText;
        internal static string showSignUp;
        internal static int typeOfChair;
        internal static DateTime fTime;
        internal static DateTime eTime;
        internal static DateTime step1;
        internal static DateTime step2a;
        internal static DateTime step2b;
        internal static DateTime step2c;
        internal static string startDate;
        internal static string endDate;
        internal static bool isQuery;
        internal static bool isComplied;
        internal static bool isSlow;
        internal static bool isClear;
        internal static bool isSupervisor;

        internal static string Hash(decimal identificationNumber)
        {
            var salt1 = "jdhjdbbgh@fcshbsg@hbjksb";
            var salt2 = "hhggbkklklkl;ujnk*jnknk)";
            var bytes = new UTF8Encoding().GetBytes(salt1 + identificationNumber + salt2);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }


    }
}
