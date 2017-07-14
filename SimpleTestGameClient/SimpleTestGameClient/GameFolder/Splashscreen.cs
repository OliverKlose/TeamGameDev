using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestGameClient.GameFolder
{
    public class Splashscreen
    {
        Game game;
        private float timer;
        public Splashscreen (Game pGame) 
        {
            game = pGame;
        }

        public  void LoadContent()
        {
            
        }

        public  void Initialize()
        {

        }

        public  StateMachine Update(GameTime gameTime)
        {
            timer += gameTime.DeltaTime;
            if (timer > 3)
            {
                timer = 0;
                Console.WriteLine("Next State reached");
                return StateMachine.IntroScreen;
                
            }
            return StateMachine.Splashscreen;
        }

        public  void Draw(GameTime gameTime)
        {
           
        }
    }
}
