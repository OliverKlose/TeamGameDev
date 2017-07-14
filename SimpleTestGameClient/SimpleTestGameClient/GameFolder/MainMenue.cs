using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestGameClient.GameFolder
{
    public class MainMenue
    {
        Game game;
        private FloatRect Rectangle;
        private Texture texture;
        Ui.Button testbutton;
        public MainMenue(Game pGame)
        {
            game = pGame;
        }

        public void LoadContent()
        {

        }

        public void Initialize()
        {
            testbutton = new Ui.Button(game, new FloatRect(new Vector2f(200f,200f), new Vector2f(200f,75f)));
        }

        public StateMachine Update(GameTime gameTime)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.F1))
            { 
                Console.WriteLine("Next State reached");
                return StateMachine.Options;

            }
            else if (testbutton.getRectangle().Contains(Mouse.GetPosition().X, Mouse.GetPosition().Y) && Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                Console.WriteLine("Next State reached");
                return StateMachine.Options;
            }
            return StateMachine.MainMenue;
        }

        public void Draw(GameTime gameTime)
        {
            testbutton.Draw(gameTime);
        }
    }
}
