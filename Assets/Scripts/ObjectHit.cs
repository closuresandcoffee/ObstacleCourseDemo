using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private int score = 0;

    // Start is called before the first frame update
    private void Start()
    {
        this.meshRenderer = this.GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "Player" && collision.gameObject.tag != "Hit")
        {
            this.score++;
            Debug.Log("You've bumped into a thing " + this.score + " times");
        }

        if (collision.gameObject.tag == "Player")
        {
            this.meshRenderer.material.color = Color.red;
            this.gameObject.tag = "Hit";
        }
    }
}
