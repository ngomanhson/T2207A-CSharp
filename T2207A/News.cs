using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;


        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AverageRate
        {
            get => averageRate;
        }


        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Average Rate: " + AverageRate);
        }

        public void Calculate(int[] RateList)
        {
            int sum = 0;
            for (int i = 0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            averageRate = (float)sum / RateList.Length;
        }
    }
}
