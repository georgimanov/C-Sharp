using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string baseUrl = "https://softuni.bg/users/profile/show/";
            //const string baseUrl = "https://softuni.bg/forum?page=0&pageSize=5000";
            //get content from forum: https://softuni.bg/forum/4400/0/100

            const string fileName = "content";
            const string user = "RoYaL";
            const string forumBaseUrl = "https://softuni.bg/forum/";

            var list = new List<int>();


            for (int i = 4; i < 4500; i++)
            {
                var spider = new Crawler();
                var htmlContent = spider.GetHtml(forumBaseUrl + i + "/0/100");
                Console.Write("Forum [" + i +"]");
                if (htmlContent.ToString().Contains(user))
                {
                    list.Add(i);
                    Console.Write("[1]");
                }
                else
                {
                    Console.Write("[0]");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Completed");
            Console.WriteLine(string.Join(", ", list));
            Console.ReadLine();
            //try
            //{
            //    var spider = new Crawler();

            //    var htmlContent = spider.GetHtml(forumBaseUrl);
            //    spider.SaveHtmlContent(htmlContent, fileName);

            //}
            //catch (Exception e)
            //{
            //    throw new Exception("There's an error");
            //}
            //finally
            //{
            //    Console.WriteLine("Process comepleted!");
            //    Console.ReadLine();
            //}
        }
    }
}
