using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniConvert
{
    class TextCompare
    {
        public static string sOutList = String.Empty;

        //remove duplicates
        public static bool AreDups(List<string> list)
        {   if (list.Count == 0)
                return false;
            bool ret = false;
            sOutList = string.Empty;
            var outList = new List<string>();
            list.Sort();
            outList.Add(list[0]);
            int initCount = list.Count;
            // take second.., check if it is already in outList
            for (int i = 1; i < initCount; i++)
            {
                //int j = 0; // temp count
                //foreach (var s in list)
                //{
                //    if (s == list[i]) j++;

                //}
                //string st = string.Empty;
                //if (j > 1)
                //     st = @"it is there more then twice";
                bool exist = false;
                foreach (var s in outList)
                {
                    if (s == list[i])
                    {
                        exist = ret = true;
                    }
                        

                }
                if (!exist) outList.Add(list[i]);
            }

            if (ret)
                foreach (var line in outList)
                    TextCompare.sOutList += line + "\n";
            return ret;
        }






        // two lists in, two lists out - alone at left, alone at right
        public static bool IsDifferent(List<string> left, List<string> right)
        {
            bool ret = false;
            // check if both has count
            // sort
            if (left.Count > 0)  left.Sort();
            if (right.Count > 0) right.Sort();
            // side by side
            // take first in both
            // if == take second
            // if <> candidate to be alone on the left. Check all in right ?

            //Absolutely easiest algorithm, dont care about eff.






            return true; // 
        }

        internal static string GetOutList()
        {
            //throw new NotImplementedException();
            return sOutList;

        }
    }
}
