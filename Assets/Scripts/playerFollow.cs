using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(this.transform.position.x, this.transform.position.y, player.transform.position.z) + offset;
        this.transform.position = position;
    }
}
