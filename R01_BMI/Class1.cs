using System;
using System.Collections.Generic;
using System.Text;

namespace R01_BMI
{
    class BMI
    {
        double[] thr = { 40, 35, 30, 25, 18.5 };
        String[] s = { "肥満（4度）", "肥満（3度）","肥満（2度）",
                        "肥満（1度）","普通体重","低体重" };

        public string getBMI(double h, double w)
        {
            double result = 0;

            result = Math.Truncate((w / (h * h)) * 100.0) / 100.0;

            int i = 0;
            string obe = "";

            while (i < thr.Length)
            {
                if (result >= thr[i])
                {
                    obe = s[i];
                    break;
                }
                obe = s[i + 1];
                i++;
            }

            return "BMI : " + result + "   " + obe;
        }
    }
}
