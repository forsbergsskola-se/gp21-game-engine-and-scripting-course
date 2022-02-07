using UnityEngine;

public class GameObjectToggler : MonoBehaviour
{
    public void ToggleGameObject()
    {
        // if (gameObject.activeSelf)
        //     gameObject.SetActive(false);
        // else
        //     gameObject.SetActive(true);
        //This does the same as the code above.
        gameObject.SetActive(!gameObject.activeSelf);
    }
}