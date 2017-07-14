using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace SimpleTestGameClient
{
    public abstract class GameLoop
    {
        public const int targetFps = 60;
        public const float timeUntilUpdate = 1f/targetFps;

        public RenderWindow window { get; protected set; }
        public GameTime gameTime { get; protected set; }
        public Color windowClearColor { get; protected set; }



        protected GameLoop(uint windowWidth, uint windowHeight, string windowTitle, Color windowClearColor)
        {
            this.windowClearColor = windowClearColor;
            this.window = new RenderWindow(new VideoMode(windowWidth, windowHeight), windowTitle);
            this.gameTime = new GameTime();

            window.Closed += WindowClosed;
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            window.Close();
        }

        public void Run()
        {
            LoadContent();
            Initialize();

            float totalTimeBeforeUpdate = 0f;
            float previousTimeElapsed = 0f;
            float deltaTime = 0f;
            float totalTimeElapsed = 0f;

            Clock clock = new Clock();

            while(window.IsOpen)
            {
                window.DispatchEvents();

                totalTimeElapsed = clock.ElapsedTime.AsSeconds();
                deltaTime = totalTimeElapsed - previousTimeElapsed;

                previousTimeElapsed = totalTimeElapsed;

                totalTimeBeforeUpdate += deltaTime;

                if(totalTimeBeforeUpdate >= timeUntilUpdate)
                {
                    gameTime.Update(totalTimeBeforeUpdate, clock.ElapsedTime.AsSeconds());
                    totalTimeBeforeUpdate = 0f;

                    Update(gameTime);

                    window.Clear(windowClearColor);

                    Draw(gameTime);

                    window.Display();
                }
            }
        }
        public abstract void LoadContent();
        public abstract void Initialize();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);
    }
}
