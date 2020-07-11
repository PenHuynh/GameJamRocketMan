using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_rigidbody2D;
    public float m_jumpForce;
    public float m_fallForce;
    public float m_moveSpeed;

    public GameObject m_model;
    public Camera m_camera;

    public int m_jumpLimit;


    // Start is called before the first frame update
    void Start()
    {

        m_rigidbody2D = m_model.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
        if(Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody2D.AddForce((Vector3.right * m_moveSpeed) * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody2D.AddForce((Vector3.right * -1) * m_moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody2D.AddForce((Vector3.up * -1) * m_fallForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space)&& m_jumpLimit > 0)
        {
            m_rigidbody2D.AddForce((transform.up * m_jumpForce) * Time.deltaTime, ForceMode2D.Impulse);
            m_jumpLimit -= 1;
        }




        // Camera movement
        Vector3 cameraPos = new Vector3(m_model.transform.position.x, m_model.transform.position.y, m_camera.transform.position.z);
        m_camera.transform.position = cameraPos;

        // Player container movement

    }


    void LateUpdate()
    {
        //this.transform.position = m_model.transform.position;
    }



}
