using StorageApp.Data;
using StorageApp.Domain;

namespace StorageApp.UI
{
    class Programm
    {
        private static StorageContext _context = new StorageContext();

        private static void Main(string[] args)
        {
            _context.Database.EnsureCreated();

            GetArticles("Before add");

            //AddArticle(new[] { "Focus Jam2" });

            var articles = _context.Articles.ToList();
            var foo = articles.Find(x => x.Id == 1);
            foo.Name = "Betty Wheel";
            foo.Description = "Tire from Schwalbe";


            var focusjam = articles.Find(x => x.Name == "Focus Jam2");

            focusjam?.Parts.Add(new Part { Articles = new List<Article> { foo } });

            // store changes
            //_context.SaveChanges();

            GetArticles("After add");

            Console.Write("Press any key...");
            Console.ReadKey();
        }

        private static void AddArticle(string[] articleNames)
        {
            foreach (var articleName in articleNames)
            {
                var article = new Article { Name = articleName };
                _context.Articles.Add(article);
            }

            _context.SaveChanges();
        }

        private static void GetArticles(String text)
        {
            var articles = _context.Articles.ToList();

            Console.WriteLine($"{text}: Article count is: {articles.Count}");

            foreach (var article in articles)
            {
                Console.WriteLine(article.Name);
                if (article.Parts.Any())
                {
                    foreach (var articlePart in article.Parts)
                    {
                        Console.WriteLine($"Article has : {articlePart.Articles.Count} part(s)");
                    }
                }
                else
                {
                    Console.WriteLine($"Article has no other parts.");
                }
            }
        }
    }
}


