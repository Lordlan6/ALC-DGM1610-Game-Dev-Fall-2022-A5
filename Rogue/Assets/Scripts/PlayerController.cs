using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //how fast the player moves
    public float hInput; //horizontal Input
    public float vInput; // vertical input
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");//a and d keys
        vInput = Input.GetAxis("Vertical");// w and s keys

        transform.Translate(Vector2.right * speed * hInput * Time.deltaTime);//left and right
        transform.Translate(Vector2.up * speed * vInput * Time.deltaTime);//up and down
    }
}
