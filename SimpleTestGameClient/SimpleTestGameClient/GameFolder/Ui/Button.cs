using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestGameClient.GameFolder.Ui
{
    class Button
    {
        private FloatRect Rectangle;
        private Texture NormalTexture;
        private Sprite NormalSprite;
        private Texture HoveredTexture;
        private Game game;

        public Button(Game pGame, FloatRect pRectangle )
        {
            game = pGame;
            NormalTexture = new Texture(@"Content\UI\Button\Button_Raw.png");
            NormalSprite = new Sprite(NormalTexture);

            pRectangle = Rectangle;
            NormalSprite.Position = new Vector2f(Rectangle.Top, Rectangle.Left);
            NormalSprite.Color = Color.White;

            NormalSprite.Scale = new Vector2f(Rectangle.Width, Rectangle.Height);
            //Rectangle = new FloatRect(new Vector2f(40f, 200f), new Vector2f(400f, 400f));
        }

        public void Draw(GameTime gameTime)
        {
            game.window.Draw(NormalSprite);
        }

        public FloatRect getRectangle()
        {
            return Rectangle;
        }
    }
}
