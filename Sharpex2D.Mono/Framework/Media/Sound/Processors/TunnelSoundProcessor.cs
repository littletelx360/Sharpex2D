﻿using System;
using Sharpex2D.Framework.Math;

namespace Sharpex2D.Framework.Media.Sound.Processors
{
    [Developer("ThuCommix", "developer@sharpex2d.de")]
    [Copyright("©Sharpex2D 2013 - 2014")]
    [TestState(TestState.Untested)]
    public class TunnelSoundProcessor : ISoundProcessor
    {
        #region ISoundProcessor Implementation

        /// <summary>
        ///     Updates the SoundProcessor.
        /// </summary>
        /// <param name="listenerPosition">The ListenerPosition.</param>
        /// <param name="soundOriginPosition">The SoundOriginPosition.</param>
        public void Update(Vector2 listenerPosition, Vector2 soundOriginPosition)
        {
            if (Length <= 0) throw new InvalidOperationException("The length can not be lower or equal to zero.");

            //the sound origin is on the end of the tunnel
            SoundManager.Balance = 0.5f;

            float distanceToOrigin = (soundOriginPosition - listenerPosition).Length;
            if (distanceToOrigin > Length)
            {
                SoundManager.Volume = 0f;
            }
            else
            {
                float volume = 1f - (distanceToOrigin/Length);
                SoundManager.Volume = volume;
            }
        }

        /// <summary>
        ///     Gets the SoundManager.
        /// </summary>
        public SoundManager SoundManager { get; private set; }

        #endregion

        /// <summary>
        ///     Initializes a new TunnelSoundProcessor.
        /// </summary>
        public TunnelSoundProcessor()
        {
            SoundManager = (SoundManager) SGL.Components.Get<SoundManager>().Clone();
        }

        /// <summary>
        ///     Sets or gets the Length.
        /// </summary>
        public float Length { set; get; }
    }
}