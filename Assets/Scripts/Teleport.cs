using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Transform headset;
    public Transform teleportLocation;
    public Transform originalPosition;

    private bool isTeleported = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {

            if (isTeleported)
            {
                headset.position = originalPosition.position;
                isTeleported = false;
            } else
            {
                headset.position = teleportLocation.position;
                isTeleported = true;
            }
        };

    }
}
