using System;

namespace HackerRankCode
{
    /*
     * This program takes a standard time as input.
     * Then it converts it into military time and returns.
     * Eg: 07:45:25PM is converted to 19:45:25 in military time.
     */
    class TimeConversion
    {
        public string timeConversion(string s)
        {
            String military;
            int index = Convert.ToInt32(s.Substring(0, 2));

            if (s[8] == 'A')
            {
                //If standard time is 12:ab:cdAM, then military time is 00:ab:cd
                if (index == 12)
                    military = "00" + s.Substring(2, 6);
                //Otherwise the AM times remains as it is just the AM postscript is dropped.
                else
                    military = s.Substring(0, 8);
            }
            else
            {
                //If standard time is 12:ab:cdPM, then military time is 12:ab:cd
                if (index == 12)
                    military = s.Substring(0, 8);
                //The PM times are added by 12 to convert it to military time.
                else
                    military = (index + 12).ToString() + s.Substring(2, 6);
            }

            return military;
        }
    }
}
