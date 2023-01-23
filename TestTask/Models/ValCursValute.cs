namespace TestTask.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ValCursValute
    {   
        public ushort NumCode { get; set; }
        public string CharCode { get; set; }
        public ushort Nominal { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }
    }
}
