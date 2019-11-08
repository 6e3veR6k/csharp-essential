using System;
using System.Collections;
using System.Collections.Specialized;

namespace Exemple9_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region first
            /*
            string[] strArray = { "First", "Second", "Third" };

            Console.WriteLine("This array has {0} items.", strArray.Length);


            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }

            Array.Reverse(strArray);

            Array.Resize<string>(ref strArray, 10);

            strArray[3] = "new one";
            strArray[4] = "new one";
            strArray[5] = "new one";
            strArray[6] = "new one";
            strArray[7] = "new one";
            strArray[8] = "new one";
            strArray[9] = "new one";

            foreach (string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}", s);
            }
            */
            #endregion

            #region second

            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });

            StringCollection someStrings = new StringCollection();
            someStrings.AddRange(new string[] { "First", "Second", "Third" });

            #endregion

            #region third

            int valInt = 89892;

            object obj = valInt;

            int vlInt2 = (int)obj;

            string str = "abc";
            string[] temp = str.Split();
            Array.Reverse(temp);
            return String.Join("", temp);

            #endregion

            Console.ReadLine();
        }
    }
}
