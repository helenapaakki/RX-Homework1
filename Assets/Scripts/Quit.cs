using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{
    public InputActionReference action;

    void Start()
    {

    }

    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            UnityEditor.EditorApplication.isPlaying = false;
        };
    }
}
