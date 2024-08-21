using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class inimigo : MonoBehaviour

{
void Start()
    {

    }

    void Update()
    {
        transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Faca"))
        {
            Destroy(gameObject);
        }
    }
}