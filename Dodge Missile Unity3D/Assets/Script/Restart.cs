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
       Msg.text = "Press to Restart";
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Msg.text = "Restarting...!";
            Invoke("Restarter", 1f);
        }
    }

    void Restarter()
    {
        SceneManager.LoadScene("lvl01");
    }
    
}
