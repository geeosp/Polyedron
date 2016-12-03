using UnityEngine;
using System.Collections;
[RequireComponent(typeof(SpriteRenderer))]
public class ParalaxControl : MonoBehaviour {


    public float relativeVelocity = -1.0f;
    public float gameSpeed = 1.0f;



    
    
    void FixedUpdate()
    {
      

        Vector3 pos = transform.position;
        pos.x = pos.x + Time.deltaTime * relativeVelocity*gameSpeed;
        transform.position = pos;

        

    }
    void OnBecameVisible()
    {
       
            Vector3 pos = transform.position;
        pos.x = transform.position.x + GetComponent<Renderer>().bounds.size.x;
        Instantiate(gameObject, pos, Quaternion.identity);


    }
    void OnBecameInvisible()
    {
        print("Not visible anymore");
        Destroy(gameObject);
    }

}
