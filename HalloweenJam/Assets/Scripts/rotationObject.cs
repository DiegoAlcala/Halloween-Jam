using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationObject : MonoBehaviour
{
    public Vector3 rotacion = new Vector3(0, 50, 0);
    public float speedRotation = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate((rotacion)* speedRotation * Time.deltaTime);
    }
}
