﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }    

        public int CurrentChannel { get; private set; }

        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void ChangeChannel(int newChannel1)
        {
                    
            if (newChannel1 >= 3 && newChannel1 <= 18)
            {
                if (IsOn == true)
                {
                    CurrentChannel = newChannel1;
                } 
            }
        }

        public void ChannelUp()
        {
            if (IsOn == true)
            {
                CurrentChannel += 1;
                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }
        public void ChannelDown()
        {
            if (IsOn == true)
            {
                CurrentChannel -= 1;
                if (CurrentChannel < 3)
                {
                    CurrentChannel = 18;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume <= 9)
                {
                    CurrentVolume += 1;
                }
            }
        }

        public void LowerVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume >= 1)
                {
                    CurrentVolume -= 1;
                }
            }
        }
    }
}
