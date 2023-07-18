using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float tocdo;
    float huongx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        huongx=Input.GetAxisRaw("Horizontal");
        if(huongx!=0)//co su nhan nut trai phai
        {
            float buocdichuyen=huongx * tocdo * Time.deltaTime;
            transform.position = transform.position + new Vector3(buocdichuyen, 0, 0);
        }
    }
}
