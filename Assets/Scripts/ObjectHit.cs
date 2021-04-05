using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Material material;
    // float bumped;
    // string finalMessage;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Wall was bumped by "+ other.gameObject.name);
        // GetComponent<MeshRenderer>().material = material;
        ChangeColor();
    }

    void ChangeColor()
    {
        // bumped++;
        // // finalMessage = bumped <= 1 ? "time" : "times";
        // Debug.Log("you were bumped " + (bumped == 1 ? bumped + "time" : bumped + "times"));
        if (!material)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            return;
        }
        GetComponent<MeshRenderer>().material = material;

    }
}
