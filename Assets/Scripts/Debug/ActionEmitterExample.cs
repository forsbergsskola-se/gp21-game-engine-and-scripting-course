using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ActionEmitterExample : MonoBehaviour
{
    public Action onEmptyAction;
    public Action<float> onRandomFloatAction;
    public Action<Transform> onTransformAction;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
            onEmptyAction.Invoke();

        if (Input.GetKeyDown(KeyCode.F2))
            onRandomFloatAction.Invoke(Random.Range(0f, 100f));

        if (Input.GetKeyDown(KeyCode.F3))
            onTransformAction.Invoke(transform);
    }
}