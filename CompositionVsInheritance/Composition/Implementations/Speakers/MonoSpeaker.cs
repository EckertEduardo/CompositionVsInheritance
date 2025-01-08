﻿using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition.Implementations.Speakers
{
    internal record MonoSpeaker : ISpeaker
    {
        public void VolumeUp()
        {
            Console.WriteLine("Volume -");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volume +");
        }
    }
}
