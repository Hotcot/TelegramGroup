using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleBd
{
    class Analyzer
    {

        private string _article;
        private string[] _wordArticl;
        private string _ind;


        DataContext db;

        public string Article { get => _article; set => _article = value; }
        public string Ind { get => _ind; set => _ind = value; }
        public string[] WordArticl { get => _wordArticl; set => _wordArticl = value; }


        public Analyzer() {
            db = new DataContext();

            var articles = db.ParsData.ToList();
            var inds = db.IndificatorData.ToList();

            var objAnaliz = from article in articles
                            from ind in inds
                            select new { TextArticle = article.TextArticle, IndificTeg = ind.IndificTeg };

            foreach (var obj in objAnaliz)
            {
                Article = obj.TextArticle;
                Article = Format(Article);
                WordArticl = WprdSeparator(Article);
                WordArticl = DelWord(WordArticl);

                for (int i = 0; i < WordArticl.Length; i++)
                {
                    if (CoefSimilarity(WordArticl[i], obj.IndificTeg) != null)
                    {
                        Ind = CoefSimilarity(WordArticl[i], obj.IndificTeg);
                        db.TegsData.Add(new TegsData {Teg=Ind });
                    }

                }
            }
        }


        private static string[] WprdSeparator( string articl)
        {
            string[] tempString= articl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return tempString;
        }

        private static string CoefSimilarity(string leg, string indific)//вычесляем по %. переделать с учетом орфографии
        {
            int counterSimil = 0;
            const int coefSimilarity = 50;
            int MaxLength = 0;
            int MinLenght = 0;

            if (leg.Length >= indific.Length)
            {
                MaxLength = leg.Length;
                MinLenght = indific.Length;
            }
            else
            {
                MinLenght = leg.Length;
                MaxLength = indific.Length;
            }

            for (int i = 0; i < MinLenght; i++)
                if (leg[i] == indific[i])
                    counterSimil++;
            counterSimil = counterSimil * 100 / MaxLength;

            if (counterSimil >= coefSimilarity)
                return indific;

            else
                return null;
        }

        private static string[] DelWord(string[] stringMass)
        {
            List<string> tempList = new List<string>();
            

            for (int i = 0; i < stringMass.Length; i++)
            {
                if(stringMass[i].Length>4)
                    tempList.Add(stringMass[i]);
            }

            string[] tempArr=new string[tempList.Count];

            for (int i = 0; i < tempList.Count; i++)
                tempArr[i] = tempList[i];
            return tempArr;
        }

        private static string Format(string stringMass)
        {
               
            string pattern = "[@\\\"'\\\\////:;`~$@*.,!&?(){}^%#-_<>0-9a-z]";
            stringMass = Regex.Replace(stringMass, pattern, string.Empty);
            stringMass.ToLower();
            return stringMass;

        }
    }
}
