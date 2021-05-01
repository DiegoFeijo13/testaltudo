using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TesteAltudo.Models;

namespace TesteAltudo.Rules
{
    public class BOPageContents
    {

        public PageContentsViewModel GetURLContents(string url)
        {
            ValidateURL(url);

            string content = GetHTML(url);

            if (string.IsNullOrEmpty(content))
                throw new ArgumentException($"The URL: {url} has no contents to display. Please choose another URL.");

            PageContentsViewModel vm = new PageContentsViewModel
            {
                Images = GetImages(content, url),
                Words = GetWords(content)
            };



            return vm;
        }

        private List<string> GetImages(string content, string url)
        {
            if (string.IsNullOrEmpty(content))
                return new List<string>();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(content);

            List<string> srcs = doc.DocumentNode.Descendants("img")
                .Select(x => x.GetAttributeValue("src", null))
                .Where(x => !string.IsNullOrEmpty(x)).ToList();

            string polishedURL = url;
            if (polishedURL.EndsWith("/"))
                polishedURL.Remove(polishedURL.Length - 1, 1);

            List<string> images = new List<string>();
            foreach (string src in srcs)
            {
                if (src.StartsWith("http"))
                {
                    images.Add(src);
                    continue;
                }

                if (src.StartsWith("/"))
                    images.Add($"{url}{src}");
                else
                    images.Add($"{url}/{src}");
            }

            return images;
        }

        private List<WordCount> GetWords(string content)
        {
            if (string.IsNullOrEmpty(content))
                return new List<WordCount>();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(content);

            var pureText = doc.DocumentNode.DescendantsAndSelf()
                .Where(x => x.NodeType == HtmlNodeType.Text && x.InnerText.Trim() != "")
                .Select(x => x.InnerText.Trim());

            string text = String.Join(" ", pureText);

            var mostUsedWords = Regex.Split(text.ToLower(), @"\W+")
                .Where(s => s.Length > 3)
                .GroupBy(s => s)
                .OrderByDescending(g => g.Count())                
                .Take(10);

            List<WordCount> words = new List<WordCount>();
            foreach(var w in mostUsedWords)
            {
                words.Add(new WordCount
                {
                    Word = w.Key,
                    Count = w.Count()
                });
            }

            return words;
        }

        private void ValidateURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("[url] is empty!");
        }

        private string GetHTML(string url)
        {
            string content = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }
            return content;
        }
    }
}
