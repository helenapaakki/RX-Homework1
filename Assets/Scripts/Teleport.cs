using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public XROrigin origin;
    public Transform teleport;
    public InputActionReference button;

    private Vector3 originalPosition;
    private bool isTeleported = false;

    void OnEnable()
    {
        button.action.Enable();
        button.action.performed += OnTeleportPressed;
    }

    void OnDisable()
    {
        button.action.performed -= OnTeleportPressed;
        button.action.Disable();
    }

    void OnTeleportPressed(InputAction.CallbackContext ctx)
    {
        if (!isTeleported)
        {
            originalPosition = origin.Camera.transform.position;
            origin.MoveCameraToWorldLocation(teleport.position);
        }
        else
        {
            origin.MoveCameraToWorldLocation(originalPosition);
        }
        isTeleported = !isTeleported;
    }

}
