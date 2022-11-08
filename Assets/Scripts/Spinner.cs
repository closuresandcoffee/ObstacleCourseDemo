using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private float xAngle = 0;
    [SerializeField] private float yAngle = 0.5f;
    private float zAngle = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(this.xAngle, this.yAngle, this.zAngle);
    }
}
