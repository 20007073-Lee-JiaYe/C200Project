using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class SubStringUtl
{
   public static string Abbreviate(this string story)
   {

        if (story.Length < 30)
        {
            return story;
        }
        else
        {
            return story.Substring(0, 20) + "...";
        }
      
   }
}