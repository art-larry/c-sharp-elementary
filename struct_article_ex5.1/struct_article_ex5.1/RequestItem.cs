using System;

namespace struct_article_ex5._1
{
    struct RequestItem
    {
        Article necessaryArticle;
        int articleQuantity;

        public Article NecessaryArticle
        {
            get { return necessaryArticle; }
            set { necessaryArticle = value; }
        }

        public int ArticleQuantity
        {
            get { return articleQuantity; }
            set { articleQuantity = value; }
        }
    }
}
