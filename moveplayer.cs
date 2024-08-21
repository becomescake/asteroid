using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -7, 0);

    }

    // Update is called once per frame
    private void Update()
    {
        Movimentos();
    }
    void Movimentos()
    {
        if (Input.GetKey(KeyCode.D))
            if (transform.position.x < 15) //limita o movimento a direita
                transform.position += new Vector3(12, 0, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            if (transform.position.x > -15) //limita o movimento a esquerda
                transform.position += new Vector3(-12, 0, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            if (transform.position.y < 10) //limita o movimento a esquerda
                transform.position += new Vector3(0, 12, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            if (transform.position.y > -10) //limita o movimento a esquerda
                transform.position += new Vector3(0, -12, 0) * Time.deltaTime;
    }
}
