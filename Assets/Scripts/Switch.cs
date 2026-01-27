using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Switch : MonoBehaviour
{
    public InputActionReference action;
    private Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        light = GetComponent<Light>(); 
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            Color newColor = new Color(0.7f, 0.3f, 0.1f, 0.8f);
            light.color = newColor;
        };
    }
}
