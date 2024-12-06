using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    // Start is called before the first frame update

    public float MovementSpeed = 5.0f;
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * MovementSpeed * Time.deltaTime;
        transform.position = position;
    }
}
