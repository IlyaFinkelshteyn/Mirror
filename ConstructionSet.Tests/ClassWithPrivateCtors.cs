﻿namespace ConstructionSet.Tests
{
    public class ClassWithPrivateCtors
    {
        public string S { get; set; }
        public object O { get; set; }

        private ClassWithPrivateCtors()
        {
        }

        private ClassWithPrivateCtors(string s)
        {
            S = s;
        }

        private ClassWithPrivateCtors(object o)
        {
            O = o;
        }

        private ClassWithPrivateCtors(Parent p)
        {
        }
    }

    public class Parent { }

    public class Child : Parent { }
}
