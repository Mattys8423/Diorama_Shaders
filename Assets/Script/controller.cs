using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private CharacterController _characterController;
    [SerializeField] private GameObject player;
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float mouseSensitivity = 2f;

    private Vector3 velocity;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        // Verrouille le curseur au centre de l'écran et le cache
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Rotation horizontale (gauche-droite)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(Vector3.up, mouseX);

        // Mouvement de translation avec les touches
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Mouvement vertical avec Espace (monter) et Shift (descendre)
        float verticalMovement = 0f;
        if (Input.GetKey(KeyCode.Space)) // Monter
        {
            verticalMovement = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftShift)) // Descendre
        {
            verticalMovement = -1f;
        }

        // Calcul du vecteur de mouvement
        Vector3 move = transform.forward * verticalInput +
                       transform.right * horizontalInput +
                       transform.up * verticalMovement;

        _characterController.Move((move * (Time.deltaTime * _moveSpeed)) + velocity * Time.deltaTime);
    }
}
