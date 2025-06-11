using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

    private string Nome = "Sonic";
    private int Vida = 5;
    public float Velocidade = 2.5f;
    private bool isDead = false;
    private Rigidbody2D rb;
    public float novaG = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vida + "\n "+ Velocidade + "\n"+ Nome + "\n" + isDead);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaG;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
