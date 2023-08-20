using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TestGame
{
    public class Entity : GameComponent
    {
        public Entity(Game game) : base(game)
        {
        }

        /*public Entity() { 
        }*/
        public string Name { get; internal set; }
        public Vector2 Position { get; set; }
        public string TextureName { get; internal set; }
        public Texture2D Texture { get; internal set; }
        public virtual void SetDefaults()
        {

        }
        public override void Initialize()
        {
            //Game.Components.Add(this);
            SetDefaults();
            base.Initialize();
        }
        public void Load(ContentManager content)
        {
            Texture = content.Load<Texture2D>(TextureName);
            Console.WriteLine("Successfully loaded texture");   
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            bool preDraw = PreDraw(spriteBatch);
            if (preDraw)
            {
                spriteBatch.Draw(Texture, Position, null, Color.White, 0f, new Vector2(Texture.Width / 2, Texture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
                PostDraw(spriteBatch);
            }
            else
            {
                return;
            }
        }
        public virtual bool PreDraw(SpriteBatch spriteBatch)
        {
            return true;
        }
        public virtual void PostDraw(SpriteBatch spriteBatch)
        {

        }
        public virtual void Update()
        {

        }
    }
}