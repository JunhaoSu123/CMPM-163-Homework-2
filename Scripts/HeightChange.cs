using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightChange : MonoBehaviour
{
    public GameObject HillScale;
    public float ScaleZ = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HillScale.transform.localScale = new Vector3(100, 100, ScaleZ);
    }

    public void scaleChange(float newScaleZ)
    {
        ScaleZ = newScaleZ;
    }
}
