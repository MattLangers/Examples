using FastEnumUtility;
using System.Runtime.Serialization;

namespace Database.Enums
{
    public enum Products
    {
        [EnumMember(Value = "Sherbet Fountain")]
        [Label("F284AA7D-F280-4F81-9435-4B43B24E7BC7")]
        SherbetFountain = 1,

        [EnumMember(Value = "Cadbury Creme Egg")]
        [Label("36E3555A-4D12-455B-9915-17260E798840")]
        CadburyCremeEgg,

        [EnumMember(Value = "Curly Wurly")]
        [Label("611622E1-5C10-4E7E-A7D5-43D1457179D7")]
        CurlyWurly,

        [EnumMember(Value = "Liquorice Allsorts")]
        [Label("AE942935-A413-4C83-8D0F-5C87ED468F79")]
        LiquoriceAllsorts,

        [EnumMember(Value = "Coconut Mushrooms")]
        [Label("C67A4AFF-699F-4BA2-8513-7731864C6EFE")]
        CoconutMushrooms,

        [EnumMember(Value = "Jelly Babies")]
        [Label("822BEA15-489A-49AC-BC05-32CC6A05E2EC")]
        JellyBabies,

        [EnumMember(Value = "Dolly Mixtures")]
        [Label("FAEA9F16-A461-463D-A70E-051FB130FBD0")]
        DollyMixtures
    }
}
