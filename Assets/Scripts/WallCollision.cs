using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField] GameObject door;
    private bool isActivated;

    private void OnTriggerEnter(Collider other)
    {
        if  (!isActivated)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            this.gameObject.GetComponent<Light>().enabled = true;

            door.gameObject.GetComponent<Door>().keyActivated += 1;

            isActivated = true;
        }
    }
}
