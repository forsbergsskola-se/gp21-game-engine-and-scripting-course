using UnityEngine;

public class GameEventCallerExample : MonoBehaviour
{
    [SerializeField] private KeyCode keyToCallGameEvent;
    [SerializeField] private GameEvent gameEventToCall;

    private void Update()
    {
        if (Input.GetKeyDown(keyToCallGameEvent))
            gameEventToCall.OnGameEvent.Invoke(); //Invoke our OnGameEvent Action. This emits a event that everyone who's subscribed to it will receive.
    }
}