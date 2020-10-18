using System;
using System.Collections.Generic;
using System.Text;
using Merlin2d.Game;
using Merlin2d.Game.Actors;

namespace Merlin
{
    public class Kettle : AbstractActor
    {

        private int temperature = 25;
        private int counter;
        private bool spilled = false;

        public Kettle()
        {
            this.SetAnimation(new Animation("resources/kettle.png", 64, 49));
            this.GetAnimation().Start();
        }

        public int Temperature
        {
            get { return temperature; }
            set 
            { 
                if(Temperature >= 21 && spilled == false)
                {
                    temperature = value;
                }
            }
        }

        public int GetTemperature()
        {
            if (temperature < 60)
            {
                this.SetAnimation(new Animation("Resources/kettle.png", 64, 49));
                this.GetAnimation().Start();
                
            }
            else if (temperature >= 60 && temperature < 100)
            {
                this.SetAnimation(new Animation("Resources/kettle_hot.png", 64, 49));
                this.GetAnimation().Start();
            }
            else if (temperature >= 100)
            {
                this.SetAnimation(new Animation("Resources/kettle_spilled.png", 64, 49));
                this.GetAnimation().Start();
                Temperature = 20;
                spilled = true;
            }
            Console.WriteLine(Temperature);
            return Temperature;
        }

        public void IncreaseTemperature(int delta)
        {
            Temperature += delta;
        }
        public override void Update()
        {
            counter += 1;
            //Console.WriteLine(counter);
            if (counter % 120 == 0)
            {
                Temperature -= 1;
                GetTemperature();
            }

        }
    }
}
