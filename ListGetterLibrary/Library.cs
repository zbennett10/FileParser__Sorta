using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;





namespace ListGetterLibrary
{
    public class Library
    {
        public List<Article> Articles;

        HttpMessageHandler httpHandler = 

        HttpClient newHttp = new HttpClient();
       
        public static int[] ArticleParser(Article Articles)
        {
            string pathContent;
            string[] refinedContent;
            string[] seperators = { ",", ".", "!", "?", ":", ";", " " };
            int[] hitCounts = new int[2];
            int wordOneHit = 0;
            int wordTwoHit = 0;

            

            StreamReader SR = new StreamReader(Articles.Pathone);   
            pathContent = SR.ReadToEnd();
            refinedContent = pathContent.Split(seperators, StringSplitOptions.None);
            try
            {
                if (File.Exists(Articles.Pathone))
                {
                    if (SR.Peek() < 1)
                    {
                        SR.Close();
                        using (StreamWriter write = File.AppendText(Articles.Pathone))
                        {
                            Console.WriteLine("What do you want to add to {0}", Articles.Pathone);
                            string userText = Console.ReadLine();
                            write.WriteLine(userText);
                        }
                    }
                    else if (!File.Exists(Articles.Pathone))
                    {
                        using (StreamWriter newFileWrite = File.CreateText(Articles.Pathone))
                        {
                            Console.WriteLine("What do you want to add to {0}", Articles.Pathone);
                            string userText = Console.ReadLine();
                            newFileWrite.WriteLine(userText);
                        }
                    }

                }
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            foreach (string s in refinedContent)
            {
                if (s == Articles.WordOne)
                {
                    wordOneHit++;
                }
                else if (s == Articles.WordTwo)
                {
                    wordTwoHit++;
                }
            }
            hitCounts[0] = wordOneHit;
            hitCounts[1] = wordTwoHit;
            return hitCounts;


        }
    }

   


}
