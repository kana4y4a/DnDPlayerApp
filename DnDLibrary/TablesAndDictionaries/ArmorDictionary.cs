namespace DnDLibrary.Dictionaries
{
    using System.Collections.Generic;
    using DnDLibrary.Interfaces;
    using DnDLibrary.Models.Emuns;
    using DnDLibrary.Models.СoncreteModels.Armor;

    public static class ArmorDictionary
    {
        public static readonly IDictionary<ArmorType, IArmor> Table = new Dictionary<ArmorType, IArmor>
            {
                { ArmorType.None, null },
                // Light
                { ArmorType.Padded, new PaddedArmor() },
                { ArmorType.Leather, new LeatherArmor() },
                { ArmorType.StuddedLeather, new StuddedLeatherArmor() },
                // Medium
                { ArmorType.Hide, new HideArmor() },
                { ArmorType.ChainShirt, new ChainShirtArmor() },
                { ArmorType.ScaleMail, new ScaleMailArmor() },
                { ArmorType.Breastplate, new BreastplateArmor() },
                { ArmorType.HalfPlate, new HalfPlateArmor() },
                // Heavy
                { ArmorType.RingMail, new RingMailArmor() },
                { ArmorType.ChainMail, new ChainMailArmor() },
                { ArmorType.Splint, new SplintArmor() },
                { ArmorType.Plate, new PlateArmor() },
                // Shield
                { ArmorType.Shield, new Shield() }
            };
    }
}
