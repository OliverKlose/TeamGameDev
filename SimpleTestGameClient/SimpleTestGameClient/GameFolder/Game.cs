using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;
using SimpleTestGameClient.GameFolder;

namespace SimpleTestGameClient
{
    public class Game : GameLoop
    {
        public const uint defaultWindowWidth = 1280;
        public const uint defaultWindowHeight = 720;
        public const string gameTitle = "Test Client";
        
        public StateMachine stateMachine;

        Splashscreen splashScreen;
        IntroScreen introScreen;
        MainMenue mainMenue;
        Options options;

        public Game() : base(defaultWindowWidth, defaultWindowHeight, gameTitle, Color.Black)
        {
            
        }

        public override void LoadContent()
        {
            DebugUtility.LoadContent();
        }

        public override void Initialize()
        {
            splashScreen = new Splashscreen(this);
            introScreen = new IntroScreen(this);
            mainMenue = new MainMenue(this);
            options = new Options(this);

            stateMachine = StateMachine.Splashscreen;
            splashScreen.Initialize();
            introScreen.Initialize();
            mainMenue.Initialize();
            options.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            switch(stateMachine)
            {
                case StateMachine.Splashscreen:
                    {
                        stateMachine = splashScreen.Update(gameTime);
                    }
                    break;
                case StateMachine.IntroScreen:
                    {
                        stateMachine = introScreen.Update(gameTime);
                    }
                    break;
                case StateMachine.MainMenue:
                    {
                        stateMachine = mainMenue.Update(gameTime);
                    }
                    break;
                case StateMachine.Options:
                    {
                        stateMachine = options.Update(gameTime);
                    }
                    break;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            DebugUtility.DrawPerformanceData(this, Color.White);

            switch (stateMachine)
            {
                case StateMachine.Splashscreen:
                    {
                        splashScreen.Draw(gameTime);
                    }
                    break;
                case StateMachine.IntroScreen:
                    {
                        introScreen.Draw(gameTime);
                    }
                    break;
                case StateMachine.MainMenue:
                    {
                        mainMenue.Draw(gameTime);
                    }
                    break;
                case StateMachine.Options:
                    {
                        options.Draw(gameTime);
                    }
                    break;
            }
        }
    }
}
