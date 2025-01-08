using CompositionVsInheritance.Inheritance.BaseClass;

namespace CompositionVsInheritance.Inheritance.Phones
{
    internal record PhoneWithBluetooth : Phone
    {
        internal void ParingDevice()
        {
            Console.WriteLine("Looking for a bluetooth connection");
        }
    }
}
