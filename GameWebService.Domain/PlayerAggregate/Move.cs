using GameWebService.Domain.MovementAggregate;

namespace GameWebService.Domain.PlayerAggregate
{
    public class Move
    {
        public Move(PlayerId playerId, Direction direction)
        {
            PlayerId = playerId;
            Direction = direction;
        }

        public PlayerId PlayerId {get; set;}
        public Direction Direction {get; set;}
    }
}