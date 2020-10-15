using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class HasReadonlyInstanceField
    {
        private readonly int Foo = 300;

        [Inject]
        public HasReadonlyInstanceField(SharedDependency sharedDependency)
        {
            Debug.Log($"{nameof(HasReadonlyInstanceField)}: {Foo}, {sharedDependency.Bar}");
        }
    }
}