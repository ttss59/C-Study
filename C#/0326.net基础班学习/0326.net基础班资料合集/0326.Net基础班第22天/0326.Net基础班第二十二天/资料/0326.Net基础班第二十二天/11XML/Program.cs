using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _11XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //在内存中创建一个XML文档对象
            XmlDocument doc = new XmlDocument();
            //创建了第一行
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //将第一行放到doc中
            doc.AppendChild(dec);
            //给文档对象创建根节点
            XmlElement books = doc.CreateElement("Books");
            //将创建的根节点 添加到xml文档对象当中
            doc.AppendChild(books);
            //给根节点再添加一个子节点
            XmlElement book = doc.CreateElement("Book");
            //给根节点 添加子节点
            books.AppendChild(book);
            //继续给book添加子节点
            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "<p>金瓶梅</p>";
            book.AppendChild(name);


            XmlElement price = doc.CreateElement("Price");
            price.InnerXml = "<p>100</p>";
            book.AppendChild(price);

            XmlElement des = doc.CreateElement("Des");
            des.InnerText = "好看，顶，狂顶！！！！";
            book.AppendChild(des);
            doc.Save("new.xml");
        }
    }
}
