using System;

namespace struct_article_ex5._1
{
    struct Request
    {
        int codeOrder;

        public double SumOrderesArticles
        {
            get
            {
                double sum = 0;
                foreach (var el in listArticles)
                {
                    sum += el.PriceArticle;
                }
                return sum;
            }
        }

        public int CodeOrder
        {
            get { return codeOrder; }
            set { codeOrder = value; }
        }

        public Client Client { get; set; }

        public DateTime DateOrder { get; set; }

        public Article[] ArticlesList { get; set; }

        public PayType TypePay { get; set; }
    }
}
