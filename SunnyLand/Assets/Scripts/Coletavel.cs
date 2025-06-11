using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Coletavel : MonoBehaviour {

    private int pontos = 5;    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("jogo começou! Você tem: \n" + pontos + " pontos");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("jogo rodando");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            print("yes");
        }
              
    }
}
