using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public string left;
    public string right;
    public string up;
    public Rigidbody2D myRigid;
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(left))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 50f)
* Time.deltaTime);
        }

        if (Input.GetKey(right))
        {
            this.transform.Rotate(new Vector3(0f, 0f,
-50f) * Time.deltaTime);
        }
    }


    void FixedUpdate()
    {
        if (Input.GetKey(up))
        {
            myRigid.AddForce(this.transform.up * 5);
        }
    }

}
