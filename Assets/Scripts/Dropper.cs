using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private int timeToWait = 3;

    private MeshRenderer meshRenderer;
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        this.meshRenderer = this.GetComponent<MeshRenderer>();
        this.meshRenderer.enabled = false;

        this.body = this.GetComponent<Rigidbody>();
        this.body.useGravity = false;

        this.RandomizeObjectHeight();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this.timeToWait)
        {
            this.DropObject();
        }
    }

    void RandomizeObjectHeight()
    {
        float randomHeight = Random.Range(10.0f, 15.0f);
        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }

    void DropObject()
    {
        this.meshRenderer.enabled = true;
        this.body.useGravity = true;
    }
}
