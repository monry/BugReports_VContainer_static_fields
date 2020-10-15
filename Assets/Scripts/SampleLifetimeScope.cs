using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace BugReports20201015
{
    public class SampleLifetimeScope : LifetimeScope
    {
        [SerializeField] private SamplePresenter samplePresenter = default;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<SharedDependency>(Lifetime.Scoped);
            builder.Register<HasConst>(Lifetime.Scoped);
            builder.Register<HasInstanceField>(Lifetime.Scoped);
            builder.Register<HasReadonlyInstanceField>(Lifetime.Scoped);
            builder.Register<HasStaticField>(Lifetime.Scoped);
            builder.Register<HasReadonlyStaticField>(Lifetime.Scoped);
            builder.RegisterComponent(samplePresenter);
        }
    }
}