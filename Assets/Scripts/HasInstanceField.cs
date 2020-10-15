using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class HasInstanceField
    {
        private readonly int Foo = 200;

        [Inject]
        public HasInstanceField(SharedDependency sharedDependency)
        {
            Debug.Log($"{nameof(HasInstanceField)}: {Foo}, {sharedDependency.Bar}");
        }
    }
}