using DomainPlayerId = GameWebService.Domain.PlayerAggregate.PlayerId;
namespace GameWebService.API.Models.PlayerAggregate
{
    public class PlayerId
    {
        public PlayerId(string Id)
        {
            this.Id = Id;
        }

        public string Id {get; set;}

        public DomainPlayerId ToDomain()
        {
            return new DomainPlayerId(Id);
        }
    }
}