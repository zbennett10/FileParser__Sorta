using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ListGetterLibrary;
using System.Net.Http;




namespace ListGetter
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Article> Articles = new List<Article>();


            Articles.Add(new Article
            {   Pathone = @"C:\Users\User\Desktop\WriteLines2.txt",
                PathTwo = @"C:\Users\User\Desktop\WriteLines.txt",
                WordOne = "go",
                WordTwo = "is"});

               Article AwesomeArticle =  Articles[0];

            Articles.Add(new Article
            {
                Pathone = @"C:\Users\User\Desktop\Writetext.txt",
                PathTwo = @"C:\Users\User\Desktop\Writetext.txt",
                WordOne = "not",
                WordTwo = "the"});

            Article LameArticle = Articles[1];




            int[] totalHitCounts = Library.ArticleParser(LameArticle);
            Console.WriteLine("The word {0} was found:" +
                totalHitCounts[0] + " " + "times."
                + "\r\nThe word {1} was found:" + totalHitCounts[1] +
                " " + "times.", LameArticle.WordOne, LameArticle.WordTwo);
            Console.ReadLine();



        }
    }
}
