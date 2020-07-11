using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRotation : MonoBehaviour
{

    public GameObject m_roationPoint;
    public float m_rotationSpeed;
    // The arm will try to be this far away from the 
    // rotaiton point at all times.
    public float m_armMaxRange;

    // Since the rocket is buried in the hierarchy.
    public GameObject m_rocket;
    private Rigidbody m_rocketRigidBody;

    public float m_rocketForce = 3;
    private void Start()
    {
        m_rocketRigidBody = m_rocket.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        // Extend arm out max range.





        // Left
        if(Input.GetKey(KeyCode.A))
        {

        }
        // Right
        if(Input.GetKey(KeyCode.D))
        {

        }


        if (Input.GetKey(KeyCode.Space))
        {
            m_rocketRigidBody.AddForce((m_rocket.transform.up * m_rocketForce), ForceMode.Impulse);
        }
    }
}
