using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore3AndCSharp8.Models
{
    [Table("Profile", Schema = "MasterData")]
    public class Profile
    {
        public long ID { get; set; }

        public int RecordStatus { get; set; }

    }

    [Table("UnitToProfile", Schema = "MasterDataMapping")]
    public class UnitToProfile
    {
        public long ProfileID { get; set; }
        public Profile Profile { get; set; }

        public long UnitID { get; set; }
        public Unit Unit { get; set; }
    }
    [Table("UnitType", Schema = "SystemLookup")]
    public class UnitType
    {
        public int ID { get; set; }

        public int Value { get; set; }

        public bool HasCompartment { get; set; }

        public bool HasEngine { get; set; }

        public int RecordStatus { get; set; }
    }
    [Table("UnitCompartment", Schema = "MasterData")]
    public class UnitCompartment
    {
        public long ID { get; set; }

        public int RecordStatus { get; set; } = 1;

        public short CompartmentNumber { get; set; }

        public double WorkingCapacity { get; set; }

        public double PercentageFront { get; set; }

        public double PercentageBack { get; set; }

        public double MinLoadCapacity { get; set; }

        public bool Meter { get; set; }

        public long UnitID { get; set; }
        public Unit Unit { get; set; }

        public long? ProductGroupID { get; set; }

        public bool? ProductGroupAllowed { get; set; }
    }
    [Table("Unit", Schema = "MasterData")]
    public class Unit
    {
        public long ID { get; set; }

        public string Number { get; set; }

        public string LicencePlate { get; set; }

        public int RecordStatus { get; set; } = 1;

        public Byte? SetupTime { get; set; }

        public int? DischargeSpeed { get; set; }

        public short? GPSNumber { get; set; }

        public long UnitBaseID { get; set; }

        public int UnitType { get; set; }
        [ForeignKey("UnitType")]
        public UnitType UnitTypeRef { get; set; }

        public List<UnitCompartment> UnitCompartments { get; set; }


        public List<UnitToProfile> UnitToProfile { get; set; }

        public IEnumerable<UnitToUnitCombination> UnitToUnitCombinations { get; set; }

        public bool Pump { get; set; }

        public long? BrandingID { get; set; }

        public Int16? MinHoseLength { get; set; }

    }
    [Table("UnitCombination", Schema = "MasterData")]
    public class UnitCombination
    {
        public long ID { get; set; }

        public int RecordStatus { get; set; }

        public List<UnitToUnitCombination> UnitToUnitCombination { get; set; }
    }
    [Table("UnitToUnitCombination", Schema = "MasterDataMapping")]
    public class UnitToUnitCombination
    {
        public long UnitID { get; set; }

        public long UnitCombinationID { get; set; }

        public byte Order { get; set; }

        public Unit Unit { get; set; }

        public UnitCombination UnitCombination { get; set; }
    }
}
