using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestGameClient.GameFolder
{
    public enum StateMachine
    {
        idle =0,
        Splashscreen = 10,
        IntroScreen = 20,
        MainMenue = 30,
        Options = 35,
        Credit = 37,
        Ingame = 40
    }
}
