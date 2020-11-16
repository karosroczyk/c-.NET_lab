using System;
using System.Reflection;
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile(@".\public.snk")]

namespace ClassLibrary1
{
    namespace TestLib1
    {
        public class Class
        {
            public Class()
            { }
            public string Version
            {
                get
                {
                    Assembly assembly = Assembly.GetAssembly(GetType());
                    return assembly.GetName().Version.ToString();
                }
            }
        }
    }
}
