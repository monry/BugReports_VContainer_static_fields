using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class HasConst
    {
        private const int Foo = 100;

        [Inject]
        public HasConst(SharedDependency sharedDependency)
        {
            Debug.Log($"{nameof(HasConst)}: {Foo}, {sharedDependency.Bar}");
        }
    }
}