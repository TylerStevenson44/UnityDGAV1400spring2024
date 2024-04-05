using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailSpin : MonoBehaviour
{
    public float spin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spin);
    }
}
