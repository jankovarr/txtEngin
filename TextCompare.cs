using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniConvert
{
    class TextCompare
    {
        public static char status = '0'; // 0 after start/reset, r awaiting right side.
        public static string sOutList = String.Empty;
        public static List<string> unDupsList = new List<string>();
        // Sort,remDups, Create left unique, Unique on right.
        public static List<string> left; // = new List<string>();
        public static List<string> right; // = new List<string>();
        //format vstupu: xxx\tbbb   čísla oddělené tabem

        public static void resetStat()
        {
            status = '0';
        }

        // nejprve full sloupec, pak sloupec od customera.
        public static char AddLeftRight(List<string> added)
        {
            List<string> li;
            

            if (AreDups(added))
                li = unDupsList;
            else
                li = added;

            if (status == '0') { left = li; status = 'l'; }
            else if (status == 'l') { right = li; status = 'r'; }

            return status;
        }

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
            {
                foreach (var line in outList)
                    TextCompare.sOutList += line + "\n";
                unDupsList = outList;
            }
                
            return ret;
        }

        // two lists in, two lists out -  return missing on right
        public static List<string> GetDiffList()
        {
            var retList = new List<string>();
            // side by side
            // take first in left, if not on right add to list
            // if == take second
            // if <> candidate to be alone on the left. Check all in right ?
            //Absolutely easiest algorithm, dont care about eff.

            foreach (string stL in left)
            {
                bool isLonR = false;
                foreach (string stR in right)
                {
                    if (stL == stR) isLonR = true;
                }
                if (!isLonR)
                    retList.Add(stL);
            }
            if (retList.Count == 0) retList.Add("Equal");
            status = '0';
            return retList; // 
        }

        internal static string GetOutList()
        {
            //throw new NotImplementedException();
            return sOutList;

        }
    }
}
