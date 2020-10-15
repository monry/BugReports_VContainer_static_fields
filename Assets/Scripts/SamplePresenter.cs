using UnityEngine;
using VContainer;

namespace BugReports20201015
{
    public class SamplePresenter : MonoBehaviour
    {
        [Inject]
        public void Construct(HasConst hasConst, HasInstanceField hasInstanceField, HasReadonlyInstanceField hasReadonlyInstanceField, HasStaticField hasStaticField, HasReadonlyStaticField hasReadonlyStaticField)
        {
            Debug.Log(hasConst);
            Debug.Log(hasInstanceField);
            Debug.Log(hasReadonlyInstanceField);
            Debug.Log(hasStaticField);
            Debug.Log(hasReadonlyStaticField);
        }
    }
}