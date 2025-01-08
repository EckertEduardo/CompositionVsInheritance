using CompositionVsInheritance.Inheritance.Phones;
using CompositionVsInheritance.Inheritance.UrbanVehicles;

namespace CompositionVsInheritance.Inheritance
{
    internal class InheritanceExample
    {
        public static void Run()
        {
            Console.WriteLine("\nInheritance Example:");

            //The 'PhoneWithBluetooth' is a child class, who inheritance from a phone
            var phone = new PhoneWithBluetooth();

            Console.WriteLine("\nPhone With Bluetooth and Headphone Jack:");

            // The 'Phone' is a base class.
            // When this class was designed at the beginning of the project,
            // it considered that all phones had a headphone jack and a camera,
            // and you can turn it on and off of course
            Console.WriteLine($"{phone} \n");

            phone.TurnOn();

            phone.TakePhoto();
            phone.PlugHeadphone();
            phone.ParingDevice();

            phone.TurnOff();


            Console.WriteLine("----------------------------------------------------");

            //Some time later, a cell phone was launched without a headphone jack, but maintaining other features
            var phoneWithoutHeadphoneJack = new PhoneWithoutHeadphoneJack();
            Console.WriteLine("\nPhone Without Headphone Jack:",);
            Console.WriteLine($"{phoneWithoutHeadphoneJack} \n");

            phoneWithoutHeadphoneJack.TurnOn();

            phoneWithoutHeadphoneJack.TakePhoto();
            //We need override this method,because we can't plug a headphone in this phone, a exception should be thrown at this point
            phoneWithoutHeadphoneJack.PlugHeadphone();
            phoneWithoutHeadphoneJack.ParingDevice();

            phoneWithoutHeadphoneJack.TurnOff();
        }
    }
}
