using UnityEngine;

//For this example we only have one listener, but one big advantage with events is that you can have multiple listeners all listening to the same event.
public class ActionListenerExample : MonoBehaviour
{
    [SerializeField] private ActionEmitterExample actionEmitter;

    private void OnEnable() => Subscribe();
    private void OnDisable() => Unsubscribe();

    private void Subscribe()
    {
        actionEmitter.onEmptyAction += EmptyActionMethod;
        actionEmitter.onRandomFloatAction += RandomFloatActionMethod;
        actionEmitter.onTransformAction += TransformActionMethod;
        actionEmitter.onMultipleDataAction += MultipleDataActionMethod;
    }

    private void Unsubscribe()
    {
        actionEmitter.onEmptyAction -= EmptyActionMethod;
        actionEmitter.onRandomFloatAction -= RandomFloatActionMethod;
        actionEmitter.onTransformAction -= TransformActionMethod;
        actionEmitter.onMultipleDataAction -= MultipleDataActionMethod;
    }

    //It's not a requirement for the methods to be static. It just fit nicely in this case.
    private static void EmptyActionMethod() => Debug.Log("Empty action was emitted.");
    private static void RandomFloatActionMethod(float randomFloat) => Debug.Log($"Our random float is: {randomFloat}");
    private static void TransformActionMethod(Transform emittedTransform) => emittedTransform.position += Vector3.up;
    private static void MultipleDataActionMethod(bool boolValue, int intValue) => Debug.Log($"Bool: {boolValue} Int: {intValue}");
}