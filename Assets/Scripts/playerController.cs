using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float speed;
    [SerializeField] private float inputSensitity;
    [SerializeField] private Gun gun;
    [SerializeField] private float shootingRate;
    [SerializeField] private List<Transform> constarint;
    [SerializeField] private Transform playerMesh;
    private Quaternion defaultRotation;
    private bool shootable;
    private bool isRotating;
    private bool rotateable;
    private float inputs;
    void Start()
    {
        defaultRotation = playerMesh.rotation;
        shootable = true;
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Inputs();
        this.Movement();
        this.Shoot();
    }
    private void Inputs()
    {
        inputs = Input.GetAxis("Horizontal");
        if(inputs > 0)
        {
            playerMesh.rotation = Quaternion.Euler(playerMesh.rotation.x, 60, playerMesh.rotation.z);
            if (Vector3.Distance(this.transform.position, constarint[1].position) <= 1f)
            {
                rotateable = false;
            }
            else
            {
                rotateable = true;
            }
            if (rotateable)
            {
                isRotating = true;
            }
        }else if(inputs < 0)
        {
            playerMesh.rotation = Quaternion.Euler(playerMesh.rotation.x, -5, playerMesh.rotation.z);
            if (Vector3.Distance(this.transform.position, constarint[0].position) <= 1f)
            {
                rotateable = false;
            }
            else
            {
                rotateable = true;
            }
            if (rotateable)
            {
                isRotating = true;
            }
        }
        else
        {
            playerMesh.rotation = defaultRotation;
            isRotating = false;
        }
        print(inputs);
    }
    private void PositionConstraint()
    {
        Vector3 position = this.transform.position;
        position.x = Mathf.Clamp(position.x, constarint[0].position.x, constarint[1].position.x);
        this.transform.position = position;
    }
    private void Movement()
    {
        Vector3 direction = this.transform.forward * speed + this.transform.right * inputs * inputSensitity;
        print(direction);
        controller.Move(direction);
        this.PositionConstraint();
    }
    private void Shoot()
    {
        if (shootable && !isRotating)
        {
            StartCoroutine(ShootBullet());
        }
    }
    private IEnumerator ShootBullet()
    {
        shootable = false;
        gun.Shoot();
        yield return new WaitForSeconds(1 / shootingRate);
        shootable = true;
    }
}
