using System;
using System.Text;

namespace VirtualCommunityLibrary.Helper
{
    public static class GeneratePasswordForUserRegistration
    {
        public static string Get()
        {
            int length = 8; //default 8 digit password length
            //const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string valid = "1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}