using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolLight : MonoBehaviour
{
    public Transform SpotLight;
    public float currentTime, lifeTime;
    public bool facingRight;
    public float rightAngle;
    public float turnSpeed;
    [Header("rotation values")]
    public float xVal;
    public float yValstart, yValEnd;
    public float zVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Rotate()
    {
        SpotLight.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= lifeTime)
        {
            facingRight = true;
        }
        if (!facingRight)
        {
          SpotLight.rotation = Quaternion.Lerp(SpotLight.rotation, Quaternion.Euler(xVal, yValEnd, zVal), turnSpeed * Time.deltaTime);
        }
        else
        {
            SpotLight.rotation = Quaternion.Lerp(SpotLight.rotation, Quaternion.Euler( xVal, yValstart,zVal), turnSpeed * Time.deltaTime);
            
            if (SpotLight.eulerAngles.y <= yValstart + 1)
            {

                currentTime = 0;
                facingRight = false;
            }
        }
    }
}
