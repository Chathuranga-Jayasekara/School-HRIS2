﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace School
{
    public class utils
    {
        public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}
