using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        this.meshRenderer = this.GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.meshRenderer.material.color = Color.red;
            this.gameObject.tag = "Hit";
        }
    }
}
