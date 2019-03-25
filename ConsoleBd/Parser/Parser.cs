
using System.Collections.Generic;
using HtmlAgilityPack;

namespace ConsoleBd
{
    class Parser
    {
        ///*ЗАДАЕМ САЙТ С КОТОРОГО БУДЕМ ДРАТЬ ДАННЫЕ*/

        private static string url = "https://strana.ua/news";
        private static string url2;
        private static HtmlDocument doc;
        private static HtmlWeb hw;
        private static List<string> listTextArticle;
        private static List<string> listLink;
        private static List<string> listNameArticle;

        public Parser()
        {
            Parse();
        }

        public static void Save()
        {

        }

        public static void Parse()
        {
            hw = new HtmlWeb();
            doc = hw.Load(url);

            listTextArticle = new List<string>();
            listLink = new List<string>();
            listNameArticle = new List<string>();

            ////////////////////// список ссылок

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@class='article']"))
            {

                listLink.Add((link.Attributes["href"]).Value);
            }

            ////////////////////// список тем

            for (int i = 0; i < listLink.Count; i++)
            {
                url2 = "https://strana.ua" + listLink[i];
                HtmlWeb hw1 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc1 = hw1.Load(url2);
                foreach (HtmlNode link1 in doc1.DocumentNode.SelectNodes("//h1[@class='article']"))
                {
                    listNameArticle.Add(link1.InnerHtml);
                }

            }
            ////////////////////// список текстов
            ///
            for (int i = 0; i < listLink.Count; i++)
            {
                url2 = "https://strana.ua" + listLink[i];
                HtmlWeb hw1 = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc1 = hw1.Load(url2);
                foreach (HtmlNode link1 in doc1.DocumentNode.SelectNodes("//div[@id='article-body']"))
                {
                    listTextArticle.Add(link1.InnerHtml);

                }
            }
        }
    }
}
