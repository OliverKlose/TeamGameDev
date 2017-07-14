using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;

namespace SimpleTestGameClient
{
    public static class DebugUtility
    {
        public const string consoleFontPath = "Goldfather.ttf";

        public static Font consoleFont;
        private static Text currentState;

        public static void LoadContent()
        {
            consoleFont = new Font(consoleFontPath);
        }

        public static void DrawPerformanceData(Game game, Color color)
        {
            if (consoleFont == null)
                return;

            string totalTimeElapsed = game.gameTime.totalTimeElapsed.ToString("0.000");
            string strdeltaTime = game.gameTime.DeltaTime.ToString("0.00000");
            float FPS = 1f / game.gameTime.DeltaTime;
            string currentFPS = FPS.ToString("0.00");

            Text textTotalTime = new Text(totalTimeElapsed, consoleFont, 14);
            textTotalTime.Position = new Vector2f(4f, 8f);
            textTotalTime.Color = color;

            Text textDeltaTime = new Text(strdeltaTime, consoleFont, 14);
            textDeltaTime.Position = new Vector2f(4f, 28f);
            textDeltaTime.Color = color;

            Text textCurrentFPS = new Text(currentFPS, consoleFont, 14);
            textCurrentFPS.Position = new Vector2f(4f, 48f);
            textCurrentFPS.Color = color;

            
            switch(game.stateMachine)
            {
                case GameFolder.StateMachine.Splashscreen:
                    {
                        currentState = new Text("Splashscreen",consoleFont,14);
                    }break;
                case GameFolder.StateMachine.IntroScreen:
                    {
                        currentState = new Text("Introscreen", consoleFont, 14);
                    }
                    break;
                case GameFolder.StateMachine.MainMenue:
                    {
                        currentState = new Text("MainMenue", consoleFont, 14);
                    }
                    break;
                case GameFolder.StateMachine.Options:
                    {
                        currentState = new Text("Options", consoleFont, 14);
                    }
                    break;
            }
            currentState.Position = new Vector2f(4f, 68f);
            currentState.Color = color;

            game.window.Draw(currentState);
            game.window.Draw(textTotalTime);
            game.window.Draw(textDeltaTime);
            game.window.Draw(textCurrentFPS);
        }
    }
}
