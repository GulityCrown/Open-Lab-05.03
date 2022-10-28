using NUnit.Framework;
using System;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            return num.ToString("N0");
            
        }
    }
}
