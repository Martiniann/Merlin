using Merlin2d.Game;
using Merlin2d.Game.Actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Merlin 
{
    class Stove : AbstractActor
    {
        private int counter2;
        private int log;

        public Stove()
        {
            this.SetAnimation(new Animation("resources/stove.png", 64, 49));
            this.GetAnimation().Start();
        }

        public int Log
        {
            get { return log; }
            set
            {
                if (Log >= 0 && Log < 4)
                {
                    log = value;
                }
            }
        }

        public void AddKettle(Kettle kettle)
        {
            if (kettle != null)
            {
                //someObject exists
                //ref Kettle kettle = new Kettle();
            }

        }

        public void AddWood()
        {
            Log += 1;
        }

        public void RemoveWood()
        {
            Log -= 1;
        }

        public override void Update()
        {
            counter2 += 1;
            //Console.WriteLine(counter);
            if (counter2 % 60 == 0)
            {
                //kettle.Temperature += 1;

                if (log == 0)
                {
                    this.SetAnimation(new Animation("resources/stove_cold.png", 64, 49));
                    this.GetAnimation().Start();

                }
                else if (log > 0)
                {
                    this.SetAnimation(new Animation("resources/stove.png", 64, 49));
                    this.GetAnimation().Start();
                }
            }
        }
    }
}
