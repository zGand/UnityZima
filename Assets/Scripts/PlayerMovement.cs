using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public int points = 0;
    public bool isGameActive;

    void Start()
    {
        isGameActive = true;
    }

    void Update()
    {
        if (isGameActive)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
        }
    }
}
