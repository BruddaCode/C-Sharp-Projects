using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class methFunc
    {
        public string error = "Hey!, geen letters >:(";

        public string add(string sGetal1, string sGetal2)
        {
            try
            {
                return (Double.Parse(sGetal1) + Double.Parse(sGetal2)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }

        public string minus(string sGetal1, string sGetal2)
        {
            try
            {
                return (Double.Parse(sGetal1) - Double.Parse(sGetal2)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }

        public string multiply(string sGetal1, string sGetal2)
        {
            try
            {
                return (Double.Parse(sGetal1) * Double.Parse(sGetal2)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }

        public string divide(string sGetal1, string sGetal2)
        {
            try
            {
                return (Double.Parse(sGetal1) / Double.Parse(sGetal2)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }

        public string power(string sGetal1, string sGetal2)
        {
            try
            {
                return Math.Pow(Double.Parse(sGetal1), Double.Parse(sGetal2)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }

        public string root(string sGetal1, string sGetal2)
        {
            try
            {
                return Math.Sqrt(Double.Parse(sGetal1)).ToString();
            }
            catch (Exception ex)
            {
                return error;
            }
        }
    }
}
