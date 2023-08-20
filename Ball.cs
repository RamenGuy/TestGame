using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestGame
{
    public class Ball : Entity
    {
        public Ball(Game game) : base(game)
        {
        }

        public override void SetDefaults()
        {
            Name = "Ball";
            TextureName = "ball";
        }
        public override void Update()
        {
            //Position = new Vector2(0, 0);
            Position = new Vector2(0, 0);
        }

    }
}