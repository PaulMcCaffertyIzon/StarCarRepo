using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarCarHire.Models
{
    public class VehicleModel
    {
        public string VehicleMake { get; set; }

        public string Vehicle { get; set; }

        public int VehicleYear { get; set; }

        public string VehicleOrigin { get; set; }

        public string VehicleExteriorColour { get; set; }

        public string VehicleInteriorColour { get; set; }

        public int VehiclePassengers { get; set; }

        public bool VehicleConvertible { get; set; }

        public bool VehicleDriveSide { get; set; }

        public string VehicleLocation { get; set; }

        public string VehicleCondition { get; set; }

        public string VehicleAdditionalInfo { get; set; }

        public string VehicleEvents { get; set; }

        public decimal VehicleHalfDayPrice { get; set; }

        public decimal VehicleFullDayPrice { get; set; }

        public decimal VehicleHourlyPrice { get; set; }


    }
}