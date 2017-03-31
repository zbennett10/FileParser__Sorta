using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListGetter
{
    class Program
    {

        public static int[] ListGetter(List<Article> FirstArticle)
        {
            string pathContent;
            string[] refinedContent;
            string[] seperators = { ",", ".", "!", "?", ":", ";", " "};
            int[] hitCounts = new int[2];
            int wordOneHit = 0;
            int wordTwoHit = 0;

            StreamReader SR = new StreamReader(Article.Path);
            pathContent = SR.ReadToEnd();
            refinedContent = pathContent.Split(seperators, StringSplitOptions.None);

            foreach(string s in refinedContent)
            {
                if(s == Article.WordOne)
                {
                    wordOneHit++;
                }
                else if(s == Article.WordTwo)
                {
                    wordTwoHit++;
                }
            }
            hitCounts[0] = wordOneHit;
            hitCounts[1] = wordTwoHit;
            return hitCounts;

            
        }
        

        static void Main(string[] args)
        {
            List<Article> FirstArticle = new List<Article>();
            Article.Path = @"C:\Users\User\Desktop\WriteLines2.txt";
            Article.WordOne = "the";
            Article.WordTwo = "apple";

            int[] totalHitCounts = ListGetter(FirstArticle);
            Console.WriteLine("The word {0} was found:" +
                totalHitCounts[0] + " " + "times."
                + "\r\nThe word {1} was found:" + totalHitCounts[1] +
                " " + "times.", Article.WordOne, Article.WordTwo);
            Console.ReadLine();
         }
    }
}
