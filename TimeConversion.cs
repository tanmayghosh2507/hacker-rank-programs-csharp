using System;

namespace HackerRankCode
{
    class TimeConversion
    {
        public string timeConversion(string s)
        {
            String military;
            int index = Convert.ToInt32(s.Substring(0, 2));

            if (s[8] == 'A')
            {
                if (index == 12)
                    military = "00" + s.Substring(2, 6);
                else
                    military = s.Substring(0, 8);
            }
            else
            {
                if (index == 12)
                    military = s.Substring(0, 8);
                else
                    military = (index + 12).ToString() + s.Substring(2, 6);
            }

            return military;
        }
    }
}
