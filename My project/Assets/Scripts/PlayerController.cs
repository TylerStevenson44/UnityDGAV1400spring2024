using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("i am alive");
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
