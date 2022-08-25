using System.Runtime.Serialization;

namespace Database.Enums
{
    public enum Products
    {
        [EnumMember(Value = "Sherbet Fountain")]
        SherbetFountain = 1,

        [EnumMember(Value = "Cadbury Creme Egg")]
        CadburyCremeEgg,

        [EnumMember(Value = "Curly Wurly")]
        CurlyWurly,

        [EnumMember(Value = "Liquorice Allsorts")]
        LiquoriceAllsorts,

        [EnumMember(Value = "Coconut Mushrooms")]
        CoconutMushrooms,

        [EnumMember(Value = "Jelly Babies")]
        JellyBabies,

        [EnumMember(Value = "Dolly Mixtures")]
        DollyMixtures
    }
}
