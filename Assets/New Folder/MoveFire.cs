using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveFire : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}

