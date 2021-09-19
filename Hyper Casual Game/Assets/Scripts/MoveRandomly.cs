using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandomly : MonoBehaviour
{

    private float speed = 1.0f;
    private float horizontalInput;
    private float verticalInput;

    

    // Start is called before the first frame update
    void Start()
    {
        horizontalInput = Random.Range(-1f, 1f);
        verticalInput = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
            
           
        

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

     

}
