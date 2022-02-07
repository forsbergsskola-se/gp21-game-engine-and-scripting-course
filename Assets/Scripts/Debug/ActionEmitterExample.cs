using System;
using UnityEngine;

public class ActionEmitterExample : MonoBehaviour
{
    public Action onEmptyAction;
    public Action<float> onRandomFloatAction;
    public Action<Transform> onTransformAction;
    public Action<bool, int> onMultipleDataAction;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
            onEmptyAction.Invoke();

        if (Input.GetKeyDown(KeyCode.F2))
            onRandomFloatAction.Invoke(UnityEngine.Random.Range(0f, 100f));

        if (Input.GetKeyDown(KeyCode.F3))
            onTransformAction.Invoke(transform);

        if (Input.GetKeyDown(KeyCode.F4))
            onMultipleDataAction.Invoke(true, UnityEngine.Random.Range(0, 10));
    }
}