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
    public class IntroScreen
    {
        Game game;
        private float timer;
        public IntroScreen(Game pGame)
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
            if (timer > 3)
            {
                timer = 0;
                Console.WriteLine("Next State reached");
                return StateMachine.MainMenue;
                
            }
            return StateMachine.IntroScreen;
        }

        public void Draw(GameTime gameTime)
        {

        }
    }
}
