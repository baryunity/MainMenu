using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapsuleFade : MonoBehaviour 
{
    [SerializeField]
    private float duration = 0.55f;

    private float t = 0f;
    private Color color1 = Color.red, color2 = Color.blue;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(0);
        }

        Color color = Color.Lerp(color1, color2, t);
        t += Time.deltaTime / duration;
        GetComponent<Renderer>().material.color = color;
        if (t > duration)
        {
            t = 0;
            color1 = Color.red;
            color2 = Color.blue;
        }
    }
}
