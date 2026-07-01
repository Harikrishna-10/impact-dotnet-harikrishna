using System;

namespace Task1_17
{
    public class AccessModifierDemo
    {
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        public void ShowMethods()
        {
            PublicMethod();
            PrivateMethod();
            ProtectedMethod();
            InternalMethod();
        }
    }
}