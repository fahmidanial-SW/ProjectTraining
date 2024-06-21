namespace ProjectTraining.Domain.Entities
{
    public class TRAINING : BaseDomainEntity
    {

        #region DB Column
        public required string Title { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required int Duration { get; set; }
        public required int Fee { get; set; }
        #endregion

    }
}
