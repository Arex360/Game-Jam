using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private float far;
    [SerializeField] private List<Transform> constraint;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
        position.x = Mathf.Clamp(position.x, constraint[0].position.x, constraint[1].position.x);
        position.z += far;
        this.transform.position = position;
    }
}
