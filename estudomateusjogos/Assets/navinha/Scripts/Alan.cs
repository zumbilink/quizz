using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alan : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody2D corpoAlan;
    public BoxCollider2D colisorAlan;

    [Header("Movimenta��o")]
    public float velocidade;

    [Header("Drop")]
    public GameObject powerUp;

    // Start is called before the first frame update
    
   

    // Update is called once per frame
    void Start()
    {
        Player.instancia.alansAtivos.Add(this);
    }

    private void FixedUpdate()
    {
        corpoAlan.velocity = new Vector2(0, velocidade);
    }
    public void DroparItem()
    {
        int rnd = Random.Range(0, 10);
        if(rnd <4)
        {
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
    }
}