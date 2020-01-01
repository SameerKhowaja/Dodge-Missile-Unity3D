using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    public MeshRenderer m1, m2;
    public enemyFall_Rng1 e1;
    public enemyFall_Rng2 e2;
    public Restart rst;
    public Score sc;
    public playerMove pm;
    public AudioSource asd, back;
    float xRot = 0;
    float speed = 250;

    void FixedUpdate()
    {

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            xRot -= 160;
            rb.velocity = new Vector3(0f, 0f, -speed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(xRot * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            xRot += 160;
            rb.velocity = new Vector3(0f, 0f, speed * Time.deltaTime);
            tf.rotation = Quaternion.Euler(xRot * Time.deltaTime, 0f, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "enemy")
        {
            m1.enabled = false;
            m2.enabled = false;
            e1.enabled = false;
            e2.enabled = false;
            asd.enabled = true;
            back.enabled = false;
            sc.enabled = false;
            rst.enabled = true;
            pm.enabled = false;
        }
    }
}
