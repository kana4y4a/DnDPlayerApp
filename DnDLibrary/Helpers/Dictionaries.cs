namespace DnDLibrary.Dictionaries
{
    using System.Collections.Generic;
    using DnDLibrary.Models.Emuns;

    public static class Dictionaries
    {
        readonly static Dictionary<ArmorType, ArmorGroupType> D_ArmorType_ArmorGroupType = new Dictionary<ArmorType, ArmorGroupType>
        {
            { ArmorType.Padded, ArmorGroupType.Light },
            { ArmorType.Leather, ArmorGroupType.Light },
            { ArmorType.StuddedLeather, ArmorGroupType.Light },

            { ArmorType.Hid⁠e, ArmorGroupType.Medium },
            { ArmorType.Chain⁠S⁠hirt, ArmorGroupType.Medium },
            { ArmorType.ScaleM⁠ail, ArmorGroupType.Medium },
            { ArmorType.Breastp⁠late, ArmorGroupType.Medium },
            { ArmorType.Half⁠Plate, ArmorGroupType.Medium },

            { ArmorType.Ring⁠Mail, ArmorGroupType.Heavy },
            { ArmorType.Chain⁠Mail, ArmorGroupType.Heavy },
            { ArmorType.Splint, ArmorGroupType.Heavy },
            { ArmorType.Plate, ArmorGroupType.Heavy },

            { ArmorType.Shield, ArmorGroupType.Shield }
        };

        public static IEnumerable<ArmorType> GetArmorTypesByArmorGroup(ArmorGroupType armorGroup)
        {
            var returnList = new List<ArmorType>();
            foreach (var item in D_ArmorType_ArmorGroupType)
            {
                if (item.Value == armorGroup)
                    returnList.Add(item.Key);
            }
            return returnList;
        }

        public static ArmorGroupType GetArmorGroupTypeByArmorType(ArmorType armorType)
        {
            return D_ArmorType_ArmorGroupType[armorType];
        }
    }
}
