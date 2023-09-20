using System.ComponentModel;

namespace DesafioIbid.Enums
{
    public enum Category
    {
        [Description("Food")]
        Food =1,
        [Description("Automotive")]
        Automotive=2,
        [Description("Personal Care")]
        PersonalCare=3,
        [Description("Games")]
        Games=4,
        [Description("Books")]
        Books=5,
        [Description("Tools")]
        Tools=6,
        [Description("Eletronics")]
        Electronics=7,
        [Description("Kitchen")]
        Kitchen=8,
        [Description("Clothing")]
        Clothing=9,
        [Description("Acessories")]
        Acessories=10, 
    }
}
