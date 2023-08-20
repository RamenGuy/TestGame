using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace TestGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Texture2D ballTexture;
        //Texture2D ballGlowTexture;

        Entity[] entity = { };
        //Texture2D[] assets = { };
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        private protected void LoadEntities()
        {
            entity = entity.Append(new Ball(this)).ToArray();
        }

        protected override void Initialize()
        {
            LoadEntities();
            // TODO: Add your initialization logic here
            foreach (var entity in entity)
            {
                entity.Initialize();
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
           // ballTexture = Content.Load<Texture2D>("ball");
            //ballGlowTexture = Content.Load<Texture2D>("ballglow");

            foreach (var entity in entity)
            {
                entity.Load(Content);
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (Entity entity in entity)
            {
                entity.Update();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (Entity entity in entity)
            {
                entity.Draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}