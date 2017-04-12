using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorASCII
{
    class Aschynchro
    {
        public static async void RunAllAsync(string text)
        {
            async Task LongTask1() { ASCIIGetter.cutt(text); }
            async Task LongTask2() { ASCIIGetter.FindOperators(text); }

            Task t1 = LongTask1();
            Task t2 = LongTask2();
            await Task.WhenAll(t1, t2);
        }

    }
}
