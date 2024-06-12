using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public static player instacia;

    [Header("componentes")]
    public Rigidbody2D corpoPlayer;
    public BoxCollider2D colisorPlayer;

    [Header("movimenta��o")]
    public float inputX;
    public float inputY;
    public float velocidade;
    public bool podeMoverX;
    public bool podeMoverY;
    internal object alansAtivos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(podeMoverX)
        {
            inputX = Input.GetAxis("Horizontal");
        }

        if (podeMoverY)
        {
            inputY = Input.GetAxis("Vertical");
        }
    }
    private void FixedUpdate()
    {
        corpoPlayer.velocity = new Vector2(inputX * velocidade, inputY * velocidade);
    }
}


