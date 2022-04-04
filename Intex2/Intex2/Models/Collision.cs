using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2.Models
{
    public class Collision
    {
        [Key]
        [Required]
        public long CRASH_ID { get; set; }

        [Required(ErrorMessage = "Please enter the Date the crash occurred on")]
        public string CRASH_DATETIME { get; set; }

        public string ROUTE { get; set; }

        public double MILEPOINT { get; set; }

        public string LAT_UTM_Y { get; set; }

        public string LONG_UTM_X { get; set; }

        [Required(ErrorMessage = "Please enter the Road Name the crash occurred on")]
        public string MAIN_ROAD_NAME { get; set; }

        [Required(ErrorMessage = "Please enter the City the crash occurred in")]
        public string CITY { get; set; }

        [Required(ErrorMessage = "Please enter the County the crash occurred in")]
        public string COUNTY_NAME { get; set; }

        [Required(ErrorMessage = "Please enter a value between 1 and 5")]
        [Range(1,5)]
        public int CRASH_SEVERITY_ID { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string WORK_ZONE_RELATED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string PEDESTRIAN_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string BICYCLIST_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string MOTORCYCLE_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string IMPROPER_RESTRAINT { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string UNRESTRAINED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string DUI { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string INTERSECTION_RELATED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string WILD_ANIMAL_RELATED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string DOMESTIC_ANIMAL_RELATED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string OVERTURN_ROLLOVER { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string COMMERCIAL_MOTOR_VEH_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string TEENAGE_DRIVER_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string OLDER_DRIVER_INVOLVED { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string NIGHT_DARK_CONDITION { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string SINGLE_VEHICLE { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string DISTRACTED_DRIVING { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string DROWSY_DRIVING { get; set; }

        [Required, RegularExpression(@"^(TRUE|FALSE)$", ErrorMessage = "Please enter either 'TRUE' or 'FALSE'")]
        public string ROADWAY_DEPARTURE { get; set; }
    }
}
