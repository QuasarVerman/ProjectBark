using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bark : MonoBehaviour
{

    float m_VerticalMovement;
    float m_HorizontalMovement;
    Vector3 m_MovementDirection;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void ManageInput()
    {
        m_HorizontalMovement = Input.GetAxis("Horizontal");

        m_VerticalMovement = Input.GetAxis("Vertical");
    }

    void MoveCharacter()
    {
        m_MovementDirection.x = m_HorizontalMovement;
        m_MovementDirection.z = m_VerticalMovement;
        m_Rigidbody.AddForce(m_MovementDirection * 40.0f);
    }

    // Update is called once per frame
    void Update()
    {
        ManageInput();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }
}
