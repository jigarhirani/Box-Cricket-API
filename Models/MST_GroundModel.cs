namespace APIBOXCricket.Models
{
    public class MST_GroundModel
    {
        public int GroundID { get; set; }

        public string GroundName { get; set; }

        public string GroundNickName { get; set; }

        public int BOXCricketID { get; set; }

        public decimal GroundWidth { get; set; }

        public decimal GroundHeight { get; set; }

        public decimal GroundLength { get; set; }

        public int GroundCapacity { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPersonNumber { get; set; }

        public decimal ActualHourlyRate { get; set; }

        public decimal DiscountedHourlyRate { get; set; }

        public string? GroundImagePath1 { get; set; }

        public string? GroundImagePath2 { get; set; }

        public string? GroundImagePath3 { get; set; }

        public string? GroundImagePath4 { get; set; }
    }
}


