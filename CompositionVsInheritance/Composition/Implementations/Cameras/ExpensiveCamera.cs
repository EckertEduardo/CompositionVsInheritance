using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition.Implementations.Cameras
{
    internal record ExpensiveCamera : ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking a 4k photo");
        }
    }
}
