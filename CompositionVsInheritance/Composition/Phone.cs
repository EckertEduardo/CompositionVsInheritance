using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition
{
    internal record Phone
    {
        public bool On { get; private set; }
        public ICamera? Camera { get; init; }
        public ISpeaker? Speakers { get; init; }
        public IBluetooth? Bluetooth { get; init; }
        public IHeadphoneConnection? HeadphoneConnection { get; init; }

        internal void TurnOff()
        {
            Console.WriteLine("Phone Off");
            On = false;
        }

        internal void TurnOn()
        {
            Console.WriteLine("Phone On");
            On = true;
        }
    }
}
