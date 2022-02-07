using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    [SerializeField] private UnityEvent onGameEvent; //Should get invoked when gameEvent emits.

    private void OnEnable()
    {
        gameEvent.OnGameEvent += InvokeUnityEvent; //Subscribe to the gameEvent.OnEvent action.
    }

    private void OnDisable()
    {
        gameEvent.OnGameEvent -= InvokeUnityEvent; //Unsubscribe from the gameEvent.OnEvent action.
    }

    private void InvokeUnityEvent()
    {
        onGameEvent.Invoke();
    }
}