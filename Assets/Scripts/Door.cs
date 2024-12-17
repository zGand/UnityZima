using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int keyActivated;

    [SerializeField] int keyMax;
    [SerializeField] float speed;

    [SerializeField] GameObject rightDoor;
    [SerializeField] GameObject leftDoor;

    void Start()
    {
        keyActivated = 0;

    }

    void Update()
    {
        if (keyActivated == keyMax)
        {
            rightDoor.transform.rotation = Quaternion.Slerp(rightDoor.transform.rotation, new Quaternion (0, -90, 0, 0), speed * Time.deltaTime);
            leftDoor.transform.rotation = Quaternion.Slerp(leftDoor.transform.rotation, new Quaternion (0, 90, 0, 0), speed*Time.deltaTime);
        }
    }
}
