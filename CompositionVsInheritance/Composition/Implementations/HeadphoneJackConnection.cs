using CompositionVsInheritance.Composition.Interfaces;

namespace CompositionVsInheritance.Composition.Implementations
{
    internal record HeadphoneJackConnection : IHeadphoneConnection
    {
        public void PlugHeadphone()
        {
            Console.WriteLine("The sound will now be reproduced in your headphones");
        }
        public void UnplugHeadphone()
        {
            Console.WriteLine("The sound will now be reproduced through the speakers");
        }
    }
}
