using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ListGetterLibrary;
using System.Net.Http;



//Zach's suggestions:
//If you didn't know, you can section of your code with the '#' symbol - example:
#region
//This lets you make your code more readable when you're coding in Visual Studio.
/*

  You've done a good job so far partitioning your code into seperate concerns. Thats freaken awesome man.

  One of the most famous quotes in software is this one:
  "There are only two hard things in Computer Science: cache invalidation and naming things."

    -- Phil Karlton

  You've done a pretty good job so far in how you're naming your variables. I can't tell you enough how important this.
  I'm glad that I realized how important this was when I just started out because at my job I can see some coworkers naming things
  in a bad way and it makes it very hard to understand what's going on when you jump in to an already existing codebase.

  SO yeah, definitely work on naming things - be as specific as possible; I commented some of your code below to show you.

  Another big suggestion I have (and you'll get better and better at this as you gain more experience)
  is to (before you start writing code) - write tests for your code. I would be more than willing to teach you how to do this if you're willing to learn,
  but it is freaking awesome even though it feels weird at first. Even if you don't write tests first, before you write code you should create a mockup
  (you can use Balsimiq or another mockup-creator) and go over the high level design of your code. When I started doing this, it helped me streamline
  my building process and made things way more well-thoughout.

   Good job dude! Keep going hard man.


 */
#endregion


namespace ListGetter
{
    public class Program
    {

        static void Main(string[] args)
        {
            //try to be more specific with this name - maybe throw some sort of adjective before 'Articles'
            List<Article> Articles = new List<Article>();


            Articles.Add(new Article
            {
                Pathone = @"C:\Users\User\Desktop\WriteLines2.txt",
                PathTwo = @"C:\Users\User\Desktop\WriteLines.txt",
                WordOne = "go",
                WordTwo = "is"
            });

            //good example of a specific name haha
            Article AwesomeArticle = Articles[0];

            Articles.Add(new Article
            {
                Pathone = @"C:\Users\User\Desktop\Writetext.txt",
                PathTwo = @"C:\Users\User\Desktop\Writetext.txt",
                WordOne = "not",
                WordTwo = "the"
            });

            Article LameArticle = Articles[1];



            //great name for this array
            int[] totalHitCounts = Library.ArticleParser(LameArticle);
            Console.WriteLine("The word {0} was found:" +
                totalHitCounts[0] + " " + "times."
                + "\r\nThe word {1} was found:" + totalHitCounts[1] +
                " " + "times.", LameArticle.WordOne, LameArticle.WordTwo);
            Console.ReadLine();



        }
    }
}
