using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 offset;
    [SerializeField] private GameObject target;
    private Rigidbody rb;

    void Start()
    {
        offset = transform.position - target.transform.position; 
    }
    
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
