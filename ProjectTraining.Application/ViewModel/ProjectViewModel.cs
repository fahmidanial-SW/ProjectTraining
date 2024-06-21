namespace ProjectTraining.Application.ViewModel
{
    public class ProjectViewModel_List
    {
        public required Guid ID { get; set; }
        public required string Title { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required int Duration { get; set; }
        public required int Fee { get; set; }
    }


    public class ProjectViewModel_Insert
    {
        public required string ZoneID { get; set; }
        public required string RegionID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime EventDate { get; set; }
        public required DateTime DurationInDays { get; set; }
        public required int MinParticipant { get; set; }
        public required int MaxParticipant { get; set; }
        public required int Fee { get; set; }
    }


}
