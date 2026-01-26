using Unity.VisualScripting;
using UnityEngine;

public class Light : MonoBehaviour
{
    public Light light;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       light = GetComponent<Light>(); 

        if (Input.GetKeyDown("tab"))
        {
           Color newColor = new Color(0.7f, 0.3f, 0.1f, 0.8f); 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
