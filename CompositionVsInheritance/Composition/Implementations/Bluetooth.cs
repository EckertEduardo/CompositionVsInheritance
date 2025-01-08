using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition.Implementations
{
    internal record Bluetooth : IBluetooth
    {
        public void ParingDevice()
        {
            Console.WriteLine("Looking for a bluetooth connection");
        }
    }
}
