using Merlin2d.Game;
using System;


namespace Merlin
{
    class Program
    {
        static void Main(string[] args)
        {
            GameContainer container = new GameContainer("GAME", 1024, 768);
            container.SetMap("Resources/maps/map01.tmx");
            
            Kettle kettle = new Kettle();
            //Stove stove = new Stove();

            container.GetWorld().AddActor(kettle);
            //container.GetWorld().AddActor(stove);

            kettle.SetPosition(100, 100);
            kettle.GetAnimation().Start();

            //stove.SetPosition(200, 200);
            //stove.GetAnimation().Start();

            
            
            container.Run();
        }
    }
}
