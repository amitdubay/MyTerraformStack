using System;
using Constructs;
using HashiCorp.Cdktf;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            new MainStack(app, "azure-cdk");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}