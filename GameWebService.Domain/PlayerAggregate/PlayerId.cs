namespace GameWebService.Domain.PlayerAggregate
{
    public class PlayerId
    {
        public PlayerId(string Id)
        {
            this.Id = Id;
        }

        public string Id {get; set;}
    }
}