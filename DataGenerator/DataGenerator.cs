using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using vsCode.Model;

namespace vsCode.DataGenerator
{
    public class DataGenerator
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random _random;

        static DataGenerator() => new DataGenerator(new Random());

        public DataGenerator(Random r)
        {
            this._random = r;
        }

        public Name GenerateName() => new Name(
            RandomString(this._random, 10),
            RandomString(this._random, 10),
            RandomString(this._random, 10),
            RandomString(this._random, 2),
            RandomString(this._random, 2)
        );

        public static string RandomString(Random r, int length) =>
            new string(Enumerable.Repeat(chars, length)
                .Select(s => s[r.Next(s.Length)]).ToArray());
    }
}