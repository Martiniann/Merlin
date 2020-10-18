using Merlin2d.Game;
using Merlin2d.Game.Actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Merlin.Actors
{
    public class PowerSource : AbstractActor, ISwitchable, IObservable
    {

        private Animation animationOn;
        private Animation animationOff;



        private bool isOn = false;

        public PowerSource()
        {
            animationOff = new Animation("Resources/source_off.png", 28, 32);
            animationOn = new Animation("Resources/source_on.png", 28, 32);

            SetAnimation(animationOff);
            animationOff.Start();
            animationOn.Start();
        }

        public bool IsOn()
        {
            throw new NotImplementedException();
        }

        public void Toggle()
        {
            if (isOn)
            {
                SetAnimation(animationOff);
            }
            else
            {
                SetAnimation(animationOn);
            }

            isOn = !isOn;
        }

        public void TurnOff()
        {
            SetAnimation(animationOff);
            isOn = false;

        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {

        }
    }
    
}
