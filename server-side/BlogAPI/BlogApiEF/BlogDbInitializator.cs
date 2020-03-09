using System;
using System.Data.Entity;
using BlogDomain.Models;

namespace BlogApiEF
{
    public class BlogDbInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            context.Articles.Add(new Article
            {
                Title = "AngularJs",
                PubDate = new DateTime(2019, 9, 18),
                Text = "AngularJS — JavaScript-фреймворк с открытым исходным кодом. Предназначен для разработки одностраничных приложений[5]. Его цель — расширение браузерных приложений на основе MVC-шаблона, а также упрощение тестирования и разработки./n"+
                       "Фреймворк работает с HTML, содержащим дополнительные пользовательские атрибуты, которые описываются директивами, и связывает ввод или вывод области страницы с моделью, представляющей собой обычные переменные JavaScript. Значения этих переменных задаются вручную или извлекаются из статических или динамических JSON-данных."
            });

            context.Articles.Add(new Article
            {
                Title = "ASP.NET",
                PubDate = new DateTime(2018, 1, 9),
                Text = "ASP.NET (Active Server Pages для .NET) — платформа разработки веб-приложений, в состав которой входит: веб-сервисы, программная инфраструктура, модель программирования[1], от компании Майкрософт. ASP.NET входит в состав платформы .NET Framework[2] и является развитием более старой технологии Microsoft ASP./n"+
                       "ASP.NET внешне во многом сохраняет схожесть с более старой технологией ASP, что позволяет разработчикам относительно легко перейти на ASP.NET. В то же время внутреннее устройство ASP.NET существенно отличается от ASP, поскольку она основана на платформе .NET и, следовательно, использует все новые возможности, предоставляемые этой платформой."

            });

            context.Articles.Add(new Article
            {
                Title = "ASP.NET MVC Framework",
                PubDate = new DateTime(2016, 8, 11),
                Text = "ASP.NET MVC Framework — фреймворк для создания веб-приложений, который реализует шаблон Model-view-controller./n"+
                       "В апреле 2009 года исходный код ASP.NET MVC был опубликован под лицензией Microsoft Public License(MS - PL)[2]. 27 марта 2012 года лицензия была изменена на Apache License 2.0[3]/n"+
                       "В настоящее время разрабатывается ASP.NET MVC 6,/n"+
                       "как часть ASP.NET Core; 27 июня 2016 года состоялся выход версии 1.0.0[4]."

            });

            base.Seed(context);
        }
    }
}