using System;

namespace MethodChaining.Fluent
{
    public class FluentEnroller
    {
        public IEnroll Enroll()
        {
            return new Enroll();
        }
    }
}