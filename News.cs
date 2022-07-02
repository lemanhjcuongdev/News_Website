using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_News_Website
{
    public class News
    {
        private int id;
        private string title, content, time, category, image, url;

        public News(int id, string title, string content, string time, string category, string image, string url)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.time = time;
            this.category = category;
            this.image = image;
            this.url = url;
            //this.author = author;
        }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Time { get => time; set => time = value; }
        public string Category { get => category; set => category = value; }
        public string Image { get => image; set => image = value; }
        public string Url { get => url; set => url = value; }
        //public string Author { get => author; set => author = value; }
    }
}