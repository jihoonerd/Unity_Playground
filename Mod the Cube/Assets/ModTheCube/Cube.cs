using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rotationSpeed;
    private Vector3 rotationVector;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        InvokeRepeating("ChangeColor", 1.0f, 1.0f);
        InvokeRepeating("ChangeScale", 1.0f, 1.0f);
    }
    
    void Update()
    {
        rotationVector = new Vector3(10.0f, 5.0f, 0.0f) * rotationSpeed;
        transform.Rotate(rotationVector * Time.deltaTime);
    }

    void ChangeColor()
    {
        Material material = Renderer.material;
        float colorR = Random.Range(0, 1.0f);
        float colorG = Random.Range(0, 1.0f);
        float colorB = Random.Range(0, 1.0f);
        float colorAlpha = Random.Range(0, 1.0f);
        material.color = new Color(colorR, colorG, colorB, colorAlpha);
    }
    
    void ChangeScale()
    {
        transform.localScale = Vector3.one * Random.Range(0.5f, 5.0f);
    }
}
