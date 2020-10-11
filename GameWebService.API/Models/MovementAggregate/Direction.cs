using DomainDirection = GameWebService.Domain.MovementAggregate.Direction;
namespace GameWebService.API.Models.MovementAggregate
{
    public class Direction
    {
        public Direction(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X {get; set;}
        public float Y {get; set;}
        public float Z {get; set;}

        public DomainDirection ToDomain()
        {
            return new DomainDirection(X,Y,Z);
        }
    }
}