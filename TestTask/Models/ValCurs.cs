namespace TestTask.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ValCurs
    {
        [System.Xml.Serialization.XmlElementAttribute("Valute")]
        public ValCursValute[] Valute { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name { get; set; }
    }
}
