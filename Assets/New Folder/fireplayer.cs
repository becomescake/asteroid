using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireplayer : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        //instanciar o tiro na posicao do player e com a rotacao padrao
        GameObject faca = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //adicionar forca para cima no tiro para ele subir
        

    }
}