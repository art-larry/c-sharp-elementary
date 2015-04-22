using System;

namespace struct_article_ex5._1
{
    struct Article
    {
        int codeArticle;
        string nameArticle;
        double priceArticle;
        ArticleType typeArticle;

        public int CodeArticle
        {
            get { return codeArticle; }
            set { codeArticle = value; }
        }

        public string NameArticle
        {
            get { return nameArticle; }
            set { nameArticle = value; }
        }

        public double PriceArticle
        {
            get { return priceArticle; }
            set { priceArticle = value; }
        }

        public ArticleType TypeArticle
        {
            get { return typeArticle; }
            set { typeArticle = value; }
        }
    }
}
