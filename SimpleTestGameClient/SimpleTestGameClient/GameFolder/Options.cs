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
    public class Options
    {
        Game game;
        private float timer;
        public Options(Game pGame)
        {
            game = pGame;
        }

        public void LoadContent()
        {

        }

        public void Initialize()
        {

        }

        public StateMachine Update(GameTime gameTime)
        {
            timer += gameTime.DeltaTime;
            if (Keyboard.IsKeyPressed(Keyboard.Key.F2))
            {
                Console.WriteLine("Next State reached");
                return StateMachine.MainMenue;
                
            }
            return StateMachine.Options;
        }

        public void Draw(GameTime gameTime)
        {

        }
    }
}
