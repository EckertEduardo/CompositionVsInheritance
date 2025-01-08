using CompositionVsInheritance.Inheritance.Phones;

namespace CompositionVsInheritance.Inheritance.UrbanVehicles
{
    internal record PhoneWithoutHeadphoneJack : PhoneWithBluetooth
    {
        internal override void PlugHeadphone()
        {
            //throw new NotImplementedException("Phone don't have a headphone jack connection");
            Console.WriteLine("Exception : Phone don't have a headphone jack connection");
        }
        internal override void UnplugHeadphone()
        {
            //throw new NotImplementedException("Phone don't have a headphone jack connection");
            Console.WriteLine("Exception : Phone don't have a headphone jack connection");
        }
    }
}
