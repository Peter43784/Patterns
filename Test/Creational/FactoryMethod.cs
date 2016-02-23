using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class Application
    {

    }
    public class CSharpApplication : Application
    {
        public CSharpApplication()
        {
            Console.WriteLine("This is C# application");
        }
    }
    public class JavaApplication : Application
    {
        public JavaApplication()
        {
            Console.WriteLine("This is Java application");
        }
    }
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }
        abstract public Application Create();
    }
    public class CSharpDeveloper : Developer
    {
        public CSharpDeveloper(string name) : base(name)
        {
                
        }

        public override Application Create()
        {
            return new CSharpApplication();
        }
    }
    public class JavaDeveloper : Developer
    {
        public JavaDeveloper(string name) : base(name)
        {

        }
        public override Application Create()
        {
            return new JavaApplication();
        }
    }
}
