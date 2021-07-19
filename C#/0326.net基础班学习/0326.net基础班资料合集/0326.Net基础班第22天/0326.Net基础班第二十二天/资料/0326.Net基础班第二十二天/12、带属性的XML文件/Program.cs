using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _12_带属性的XML文件
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);


            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerXml = "杨浩然";
            order.AppendChild(customerName);

            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            orderNumber.InnerXml = "BJ333338";
            order.AppendChild(orderNumber);


            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);



            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给标签设置属性 并且给属性赋值
            orderItem1.SetAttribute("Name", "充气娃娃");
            orderItem1.SetAttribute("Count", "5");
            items.AppendChild(orderItem1);


            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给标签设置属性 并且给属性赋值
            orderItem2.SetAttribute("Name", "超人般内裤");
            orderItem2.SetAttribute("Count", "100");
            items.AppendChild(orderItem2);


            doc.Save("new2.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }
}
