using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTarget : MonoBehaviour
{
    [SerializeField] private Transform vFxGreen;
    [SerializeField] private Transform vFxRed;
    private Rigidbody bulletRigidBody;
    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        float speed = 10f;
        bulletRigidBody.velocity = transform.forward * speed;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<BulletTarget>() != null)
        {
            Instantiate(vFxGreen, transform.position, Quaternion.identity);

        }
        else
        {
            Instantiate(vFxRed, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
