using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class HasReadonlyStaticField
    {
        private static readonly int Foo = 500;

        [Inject]
        public HasReadonlyStaticField(SharedDependency sharedDependency)
        {
            Debug.Log($"{nameof(HasReadonlyStaticField)}: {Foo}, {sharedDependency.Bar}");
        }
    }
}