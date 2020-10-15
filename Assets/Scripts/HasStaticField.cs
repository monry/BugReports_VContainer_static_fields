using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class HasStaticField
    {
        private static int Foo = 400;

        [Inject]
        public HasStaticField(SharedDependency sharedDependency)
        {
            Debug.Log($"{nameof(HasStaticField)}: {Foo}, {sharedDependency.Bar}");
        }
    }
}