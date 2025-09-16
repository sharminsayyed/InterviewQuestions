namespace DependencyInjectionImplementation.DI
{
    public class Messaging:IMessaging
    {
        public string GetMessage()
        {
            return "Hello from Messaging service!";
        }
    }
}
