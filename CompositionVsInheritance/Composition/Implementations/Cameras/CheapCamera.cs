using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition.Implementations.Cameras
{
    internal record CheapCamera : ICamera
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking a photo");
        }
    }
}
