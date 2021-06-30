using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Program
    {
        public enum OutputFormat
        {
            Markdown,
            HTML
        }
       
        public interface IListStrategy
        {
            void Start(StringBuilder sb);
            void End(StringBuilder sb);
            void AddListItem(StringBuilder sb, string item);
        }

        public class HTMLListStrategy : IListStrategy
        {
            public void Start(StringBuilder sb)
            {
                sb.AppendLine("<ul>");
            }

            public void End(StringBuilder sb)
            {
                sb.AppendLine("</ul>");
            }            

            public void AddListItem(StringBuilder sb, string item)
            {
                sb.AppendLine($"    <li>{item}</li>");
            }
        }

        public class MarkDownListStrategy : IListStrategy
        {
            public void Start(StringBuilder sb)
            {

            }

            public void End(StringBuilder sb)
            {

            }

            public void AddListItem(StringBuilder sb, string item)
            {
                sb.AppendLine($" * {item}");
            }
        }

            public class TextProcessor
            {
                private StringBuilder sb = new StringBuilder();
                private IListStrategy listStrategy;

                public void setOutputFormat(OutputFormat format)
                {
                    switch (format) 
                    {
                        case OutputFormat.Markdown:
                            listStrategy = new MarkDownListStrategy();
                            break;
                        case OutputFormat.HTML:
                            listStrategy = new HTMLListStrategy();
                            break;
                        default:
                            break;                                                        
                    }
                }

                public void AppendList(IEnumerable<string> items)
                {
                    listStrategy.Start(sb);
                    foreach (var item in items)                    
                        listStrategy.AddListItem(sb, item);
                    listStrategy.End(sb);
                }

                public StringBuilder Clear()
                {
                    return sb.Clear();
                }

                public override string ToString()
                {
                    return sb.ToString();
                }
            }


        static void Main(string[] args)
        {
            var tp = new TextProcessor();
            tp.setOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "React", "Unit Testing", "Design Pattern" });
            Console.WriteLine(tp);
            
            tp.Clear();
            tp.setOutputFormat(OutputFormat.HTML);
            tp.AppendList(new[] { "React", "Unit Testing", "Design Pattern" });
            Console.WriteLine(tp);
        }

    }
}
