using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace carService_v._02
{
    [System.Xml.Serialization.XmlRoot("carService")]
    public class CarService
    {
        [System.Xml.Serialization.XmlElement("spareParts")]
        public SpareParts SpareParts { get; set; }
        [System.Xml.Serialization.XmlElement("shop")]
        public Shop Shop { get; set; }
        [System.Xml.Serialization.XmlElement("anothers")]
        public Anothers Anothers { get; set; }
        [System.Xml.Serialization.XmlElement("employees")]
        public Employees Employees { get; set; }
        [System.Xml.Serialization.XmlElement("statuss")]
        public Statuss Statuss { get; set; }
        [System.Xml.Serialization.XmlElement("cars")]
        public Cars Cars { get; set; }
    }
    public class SpareParts
    {
        [System.Xml.Serialization.XmlElement("sparePart")]
        public SparePart [] SparePartsArray { get; set; }
    }
    public class SparePart
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace ="")]
        public int sid { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string sname { get; set; }
        [System.Xml.Serialization.XmlElement("summ", Namespace = "")]
        public int ssumm { get; set; }
        [System.Xml.Serialization.XmlElement("employee", Namespace = "")]
        public int semployee { get; set; }
    }
    public class Shop
    {
        [System.Xml.Serialization.XmlElement("goods")]
        public Goods[] GoodsArray { get; set; }
    }
    public class Goods
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int gid { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string gname { get; set; }
        [System.Xml.Serialization.XmlElement("summ", Namespace = "")]
        public int gsumm { get; set; }
        [System.Xml.Serialization.XmlElement("employee", Namespace = "")]
        public int gemployee { get; set; }
    }
    public class Anothers
    {
        [System.Xml.Serialization.XmlElement("another")]
        public Another[] AnotherArray { get; set; }
    }
    public class Another
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int aid { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string aname { get; set; }
        [System.Xml.Serialization.XmlElement("summ", Namespace = "")]
        public int asumm { get; set; }
        [System.Xml.Serialization.XmlElement("employee", Namespace = "")]
        public int aemployee { get; set; }
    }
    public class Employees
    {
        [System.Xml.Serialization.XmlElement("employee")]
        public Employee[] EmployeeArray { get; set; }
    }
    public class Employee
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int eid { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string ename { get; set; }
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public int eage { get; set; }
        [System.Xml.Serialization.XmlElement("education", Namespace ="")]
        public Education eeducation { get; set; }
        [System.Xml.Serialization.XmlElement("specialization", Namespace = "")]
        public string especialization { get; set; }
    }
    public class Statuss
    {
        [System.Xml.Serialization.XmlElement("status")]
        public Status[] StatusArray { get; set; }
    }
    public class Status
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int stid { get; set; }
        [System.Xml.Serialization.XmlElement("name", Namespace = "")]
        public string stname { get; set; }
    }
    public class Cars
    {
        [System.Xml.Serialization.XmlElement("another")]
        public Car[] CarrArray { get; set; }
    }
    public class Car
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int cid { get; set; }
        [System.Xml.Serialization.XmlElement("carName", Namespace = "")]
        public string carName { get; set; }
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public byte cage { get; set; }
        [System.Xml.Serialization.XmlElement("sparePart", Namespace = "")]
        public int csparePart { get; set; }
        [System.Xml.Serialization.XmlElement("goods", Namespace = "")]
        public int cgoods { get; set; }
        [System.Xml.Serialization.XmlElement("another", Namespace = "")]
        public int canother { get; set; }
        [System.Xml.Serialization.XmlElement("status", Namespace = "")]
        public int cstatus { get; set; }
    }
    public class Education
    {
        [System.Xml.Serialization.XmlElement("school")]
        public School school { get; set; }
        [System.Xml.Serialization.XmlElement("colledge")]
        public Colledge colledge { get; set; }
    }
    public class Study
    {
        [System.Xml.Serialization.XmlAttribute("code")]
        public int code { get; set; }
        [System.Xml.Serialization.XmlAttribute("country")]
        public string country { get; set; }
        [System.Xml.Serialization.XmlAttribute("town")]
        public string town { get; set; }
    }
    public class School : Study
    {

    }
    public class Colledge: Study 
    { 
    }
}

