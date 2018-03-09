﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BPMbenchmarksGenerator
{
    public class BPMGeneratorMethods
    {
        public static int ParseStringToInteger(string s, int lowestPossibleNumber)
        {
            int integer = -2;
            string exceptionMessage = null;
            try
            {
                integer = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                exceptionMessage = "Value not provided. Please specify number in correct field.";
                throw new ArgumentNullException(exceptionMessage);
            }
            catch (FormatException)
            {
                exceptionMessage = "Provided number has to be integer!";
                throw new FormatException(exceptionMessage);
            }

            if (integer < lowestPossibleNumber)
            {
                exceptionMessage = string.Format($"Integer value should be at least {lowestPossibleNumber.ToString()}.");
                throw new Exception(exceptionMessage);
            }

            return integer;
        }

        public static string GetStartingDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

    }
}
