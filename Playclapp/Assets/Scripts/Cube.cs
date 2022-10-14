using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public float speed;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;

        if(transform.position.z >= distance)
        {
            Destroy(this.gameObject);
        }
    }


}
