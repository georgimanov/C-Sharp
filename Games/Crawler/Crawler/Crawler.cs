using System;
using System.IO;
using System.Text;

namespace Crawler
{

    using System.Net;

    public class Crawler
    {
        public StringBuilder GetHtml(string url)
        {
            string urlAddress = url;
            var data = new StringBuilder();

            var request = (HttpWebRequest)WebRequest.Create(urlAddress);
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = new StringBuilder(readStream.ReadToEnd());

                response.Close();
                readStream.Close();
            }

            return data;
        }


        public void SaveHtmlContent(StringBuilder content, string fileName)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // Write the stream contents to a new file named "AllTxtFiles.txt".
            using (var outfile = new StreamWriter(mydocpath + @"\"+ fileName + ".txt"))
            {
                outfile.Write(content.ToString());
            }
        }

        public bool CheckIfUserExistsInForumTheme(string username, StringBuilder file)
        {
            return file.ToString().Contains(username);
        }

    }
}
 
