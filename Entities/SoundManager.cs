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
    static class SoundManager
    {
        static public SoundEffectInstance[] itemPickup = new SoundEffectInstance[20];
        
        static public void PlaySound(SoundEffectInstance sfxInst)
        {
            sfxInst.Play();
        }

        static public void StopSound(SoundEffectInstance sfxInst)
        {
            sfxInst.Stop();
        }
    }
}
