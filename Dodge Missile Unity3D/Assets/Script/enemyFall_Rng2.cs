using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFall_Rng2 : MonoBehaviour
{
    public Transform tf;
    public Rigidbody rb;
    public Transform playertf;
    float zPos;
    Vector3 vec;
    float timer;

    void Update()
    {
        float zPos = Random.Range(-8.14f, -5.43f);
        vec = new Vector3(0f, 5.26f, zPos);
        if (playertf.transform.position.z < -5.32f)
        {
            vec = new Vector3(0f, 3.48f, playertf.transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "ground")
        {
            tf.position = vec;
        }
    }
}
