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
    private bool shootable;
    private float inputs;
    void Start()
    {
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
        if (shootable)
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
