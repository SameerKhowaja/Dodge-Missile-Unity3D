using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text TScore, Msg;
    private string st;

    private void Start()
    {
       st = TScore.text;
       TScore.text = st;
        Msg.text = "Press Spacebar to Restart";
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
            Invoke("Restarter", 0.5f);
    }

    void Restarter()
    {
        SceneManager.LoadScene("lvl01");
    }
    
}
