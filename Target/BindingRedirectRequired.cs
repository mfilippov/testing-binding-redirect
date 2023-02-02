using RedirectionTarget;

namespace Target;

public static class BindingRedirectRequired
{
    public static void Test()
    {
        System.Console.WriteLine(new DemoClass().DemoMethod());
    }
}