using System;
using System.IO;

namespace BindingRedirector;

public static class Program
{
    public static void Main()
    {
        var redirectedPath = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location) 
                                        ?? throw new InvalidOperationException(), "VersionRepacked", "RedirectionTarget.dll");
        AppDomain.CurrentDomain.AssemblyResolve += (_, eventArgs) =>
            eventArgs.Name.Contains("RedirectionTarget") 
                ? System.Reflection.Assembly.LoadFrom(redirectedPath) : null;
        var proxy = new Proxy();
        proxy.Test();
    }
}