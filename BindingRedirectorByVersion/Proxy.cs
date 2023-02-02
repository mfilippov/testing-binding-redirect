namespace BindingRedirector;

public class Proxy
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void Test()
    {
        Target.BindingRedirectRequired.Test();
    }
}