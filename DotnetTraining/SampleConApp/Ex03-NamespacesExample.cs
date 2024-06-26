/*
 * Namespace: Is a conceptual grouping created on the classes to avoid naming conflicts. 
 * It makes UR classes grouped conceptually, so that it is easy for segregation and organizing the classes. 
 * By default, when U create a class, it will be under the Project's namespace. The name of the Project is the name of the Namespace. 
 * All .NET Classes are grouped into namespaces, 
 * U should include the namespace by using the 'using' keyword before U refer them in UR code. Else, U must provide the fully qualified name of the class. Fully qualified name is Namespace.ClassName
 * System is the default namespace that is included in the Code. 
 */
using myConsole = System.Console;//Alias to the refered class. 

namespace SampleConApp
{
    using System;

    namespace Middleware
    {
        class MiddlewareComponent
        {
            public static void CreateComponent()
            {
                myConsole.WriteLine("Component is created");
            }
        }
    }
    class NamespaceExample
    {
        static void Main(string[] args)
        {
            Middleware.MiddlewareComponent.CreateComponent();
        }
    }
}