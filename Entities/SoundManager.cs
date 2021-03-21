using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Races.Entities;



namespace Races.Entities
{
    class SoundManager
    {
        public SoundEffectInstance[] itemPickup = new SoundEffectInstance[20];
        
        public void playSound(SoundEffectInstance sfxInst)
        {
            sfxInst.Play();
        }

        public void stopSound(SoundEffectInstance sfxInst)
        {
            sfxInst.Stop();
        }
    }
}
