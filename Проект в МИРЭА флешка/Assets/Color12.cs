using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color12 : MonoBehaviour
{
    public UnityEngine.Color color;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
    }

}
