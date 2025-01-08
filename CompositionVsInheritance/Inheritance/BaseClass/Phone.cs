namespace CompositionVsInheritance.Inheritance.BaseClass
{
    abstract record Phone
    {
        public bool On { get; set; }

        internal virtual void TurnOff()
        {
            Console.WriteLine("Phone Off");
            On = false;
        }

        internal virtual void TurnOn()
        {
            Console.WriteLine("Phone On");
            On = true;
        }

        internal virtual void TakePhoto()
        {
            Console.WriteLine("Taking a photo");
        }

        internal virtual void PlugHeadphone()
        {
            Console.WriteLine("The sound will now be reproduced in your headphones");
        }
        internal virtual void UnplugHeadphone()
        {
            Console.WriteLine("The sound will now be reproduced through the speakers");
        }

        public virtual void VolumeUp()
        {
            Console.WriteLine("Volume +");
        }

        public virtual void VolumeDown()
        {
            Console.WriteLine("Volume -");
        }
    }
}
