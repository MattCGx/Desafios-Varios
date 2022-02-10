using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyg2 : MonoBehaviour
{
  
    // Start is called before the first frame update

    [SerializeField] GameObject centralPoint;
    [SerializeField] float rotationSpeed = 50;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotationMovement(centralPoint);
    }

    void RotationMovement(GameObject PivotObject)
    {
       transform.RotateAround(PivotObject.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);


    }
}
