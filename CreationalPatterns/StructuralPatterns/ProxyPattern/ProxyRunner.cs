namespace CreationalPatterns.StructuralPatterns.ProxyPattern
{
    [Runner(Ignore = true)]
    public class ProxyRunner : IRunner
    {
        public void Run()
        {
            Proxy proxy = new Proxy();
            proxy.DoSomeWork();
        }
    }
}
