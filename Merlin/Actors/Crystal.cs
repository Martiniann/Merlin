using Merlin.Actors;
using Merlin2d.Game;
using Merlin2d.Game.Actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Merlin.actors
{
    public class Crystal : AbstractActor, ISwitchable
    {

        private Animation animationOn;
        private Animation animationOff;

        private void Notify()
        {

        }

        private bool isOn = false;

        public Crystal()
        {
            animationOff = new Animation("Resources/crystal_off.png", 28, 32);
            animationOn = new Animation("Resources/crystal_on.png", 28, 32);

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
                TurnOff;
            }
            else
            {
                TurnOn;
            }

        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        private void UpdateAnimation()
        {
            if (isOn && isPowered)
            {
                SetAnimation(animationOn);
            }
            else if (isOff && NotPowered)
            {
                SetAnimation(animationOff);
            }

        public override void Update()
        {
            
        }
    }
}
