using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public static class Check
    {
        public static void ArgumentIsNull(object argument, string errorMessage)
        {
            if (null == argument)
            {
                throw new ArgumentNullException(errorMessage);
            }
        }

        public static void ElementIsNull(object element, string errorMessage)
        {
            if (null == element)
            {
               // throw new DbElementNullException(errorMessage);
            }
        }
    }
}