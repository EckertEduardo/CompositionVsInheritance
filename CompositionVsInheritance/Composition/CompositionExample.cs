using CompositionVsInheritance.Composition.Implementations;
using CompositionVsInheritance.Composition.Implementations.Cameras;
using CompositionVsInheritance.Composition.Implementations.Speakers;

namespace CompositionVsInheritance.Composition
{
    internal class CompositionExample
    {
        public static void Run()
        {
            Console.WriteLine("Composition Example:");

            //Using composition, we have our object (phone) that is composed of different blocks/parts,
            //we can assign different parts to it and with low coupling
            var monoSpeaker = new MonoSpeaker();
            var bluetooth = new Bluetooth();
            var cheapCamera = new CheapCamera();
            var headphoneConnection = new HeadphoneJackConnection();

            //Here we are creating a Phone who contains a cheap Camera, mono speakers, a headphone jack connection and bluetooth
            var phone = new Phone()
            {
                Camera = cheapCamera,
                Speakers = monoSpeaker,
                HeadphoneConnection = headphoneConnection,
                Bluetooth = bluetooth
            };

            Console.WriteLine("\nPhone With Bluetooth and Headphone Jack:");
            Console.WriteLine($"{phone} \n");

            phone.TurnOn();

            phone.Camera.TakePhoto();
            phone.HeadphoneConnection?.PlugHeadphone();
            phone.Bluetooth.ParingDevice();
            phone.TurnOff();

            Console.WriteLine("----------------------------------------------------");

            var expensiveCamera = new ExpensiveCamera();
            var stereoSpeakers = new StereoSpeakers();

            var phoneWithoutHeadphoneJack = new Phone
            {
                Camera = expensiveCamera,
                Speakers = stereoSpeakers,
                Bluetooth = bluetooth
            };

            Console.WriteLine("\nPhone Without Headphone Jack:");
            Console.WriteLine($"{phoneWithoutHeadphoneJack} \n");

            phoneWithoutHeadphoneJack.TurnOn();

            phoneWithoutHeadphoneJack.Camera.TakePhoto();
            //This phone doesn't have a headphone connection, however we are using the null conditional operator,
            //where it will ignore the call to the method, continuing the routine normally
            phoneWithoutHeadphoneJack.HeadphoneConnection?.PlugHeadphone();
            phoneWithoutHeadphoneJack.Bluetooth.ParingDevice();

            phoneWithoutHeadphoneJack.TurnOff();
        }
    }
}
