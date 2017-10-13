using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }



    void Update() {

        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.z);

            Instantiate(thePlatform, transform.position, transform.rotation);

        }



    }
}
   
   
   
   
        
   



