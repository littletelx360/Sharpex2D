﻿using System;
using Sharpex2D.Framework.Components;

namespace Sharpex2D.Framework.Media.Sound
{
    [Developer("ThuCommix", "developer@sharpex2d.de")]
    [Copyright("©Sharpex2D 2013 - 2014")]
    [TestState(TestState.Tested)]
    public interface ISoundProvider : IComponent, IDisposable, ICloneable
    {
        /// <summary>
        ///     Sets or gets the Balance.
        /// </summary>
        float Balance { set; get; }

        /// <summary>
        ///     Sets or gets the Volume.
        /// </summary>
        float Volume { set; get; }

        /// <summary>
        ///     Sets or gets the Position.
        /// </summary>
        long Position { set; get; }

        /// <summary>
        ///     A value indicating whether the SoundProvider is playing.
        /// </summary>
        bool IsPlaying { set; get; }

        /// <summary>
        ///     Gets the sound length.
        /// </summary>
        long Length { get; }

        /// <summary>
        ///     Plays the sound.
        /// </summary>
        /// <param name="soundFile">The Soundfile.</param>
        /// <param name="playMode">The PlayMode.</param>
        void Play(Sound soundFile, PlayMode playMode);

        /// <summary>
        ///     Resumes a sound.
        /// </summary>
        void Resume();

        /// <summary>
        ///     Pause a sound.
        /// </summary>
        void Pause();

        /// <summary>
        ///     Seeks a sound to a specified position.
        /// </summary>
        /// <param name="position">The Position.</param>
        void Seek(long position);
    }
}