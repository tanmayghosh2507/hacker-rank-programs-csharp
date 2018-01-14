namespace HackerRankCode
{
    class BeautifulBinary
    {
        public int beautifulBinaryString(string b)
        {
            return (b.Length - b.Replace("010", "").Length) / 3;
        }
    }
}
