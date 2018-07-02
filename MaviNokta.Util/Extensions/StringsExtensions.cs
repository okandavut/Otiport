﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MaviNokta
{
    public static class StringsExtensions
    {
        public static string Hash(this string text,HashType type)
        {
            switch (type)
            {
                case HashType.MD5:
                    //TODO: MD5 Hash Algorithm
                    return "";
                case HashType.SHA256:
                    //TODO: SHA254 Hash Algorithm
                    return "";
                default:
                    //TODO: Default Hash
                    return text;
            }
        }
    }

    public enum HashType
    {
        MD5,
        SHA256
    }
}
