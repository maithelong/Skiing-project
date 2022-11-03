using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]  float torqueSpeed = 3f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            {
            rb.AddTorque(torqueSpeed);
        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torqueSpeed);

        }
    }
}
