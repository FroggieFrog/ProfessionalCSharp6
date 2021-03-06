﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace SortingDemo
{
    class Program
    {
        static void Main()
        {
            string[] names = {"Alabama", "Texas", "Washington",
                              "Virginia", "Wisconsin", "Wyoming",
                              "Kentucky", "Missouri", "Utah", "Hawaii",
                              "Kansas", "Louisiana", "Alaska", "Arizona"};

            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            Array.Sort(names);
            DisplayNames("Sorted using the Finnish culture", names);

            // sort using the invariant culture

            Array.Sort(names, Comparer.DefaultInvariant);
            DisplayNames("Sorted using the invariant culture", names);
        }

        public static void DisplayNames(string title, IEnumerable<string> e)
        {
            WriteLine(title);
            WriteLine(string.Join("-", e));
            WriteLine();
        }
    }
}
