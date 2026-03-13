using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoApp.Models
{
    internal class Memo
    {
        public int Id { get; }
        public string Title { get; }
        public string Contents {  get; }
        public DateTime Date { get; }

        public Memo(string Title, string Contents)
        {
            this.Title = Title;
            this.Contents = Contents;
            this.Date = DateTime.Now;
        }

        public Memo(int id, string title, string contents, DateTime date)
        {
            this.Id = id;
            this.Title = title;
            this.Contents = contents;
            this.Date = date;
        }
    }
}
