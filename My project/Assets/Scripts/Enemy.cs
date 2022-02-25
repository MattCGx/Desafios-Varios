using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject centralPoint;
    [SerializeField] float rotationSpeed = 50;
    [SerializeField] GameObject player;
    [SerializeField] float lookSpeed = 10;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotationMovement(centralPoint);
        LookAtPlayer();
    }

    void RotationMovement(GameObject PivotObject)
    {
        transform.RotateAround(PivotObject.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, lookSpeed * Time.deltaTime);
    }
}
