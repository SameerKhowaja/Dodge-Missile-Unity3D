using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFall_Rng1 : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public Transform playertf;
    float zPos;
    Vector3 vec;
    float timer;

    void Update()
    {
        float zPos = Random.Range(-5.359f, -2.4f);
        vec = new Vector3(0f, 5.2f, zPos);

        if (playertf.transform.position.z > -5.14f)
        {
            vec = new Vector3(0f, 3.48f, playertf.transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "ground" || collision.collider.name == "walls")
        {
            tf.position = vec;
        }
    }
}
