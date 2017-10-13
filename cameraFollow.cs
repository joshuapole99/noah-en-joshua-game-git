using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    [SerializeField]
    private GameObject targetToFollow;

    private Vector3 distance;

    void Start()
    {
        distance = this.transform.position - targetToFollow.transform.position;
    }

    void Update()
    {
        this.transform.position = distance + targetToFollow.transform.position;
    }
}

