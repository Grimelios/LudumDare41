using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LudumDare41
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);

			Window.Position = new Point(200, 100);
            Content.RootDirectory = "Content";
	        IsMouseVisible = true;
        }
		
        protected override void Initialize()
        {
            base.Initialize();
        }
		
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }
		
        protected override void UnloadContent()
        {
        }
		
        protected override void Update(GameTime gameTime)
        {
	        float dt = gameTime.ElapsedGameTime.Milliseconds / 1000f;
        }
		
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkRed);
        }
    }
}
