using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPatrol : MonoBehaviour
{
    public Transform SpotLight;
    public float currentTime, lifeTime;
    public bool facingRight;
    public float rightAngle;
    public float turnSpeed;
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
          SpotLight.rotation = Quaternion.Lerp(SpotLight.rotation, Quaternion.Euler(17, 42, 1), turnSpeed * Time.deltaTime);
        }
        else
        {
            SpotLight.rotation = Quaternion.Lerp(SpotLight.rotation, Quaternion.Euler(17, 112, 1), turnSpeed * Time.deltaTime);

            if (SpotLight.eulerAngles.y <= 41f)
            {

                currentTime = 0;
                facingRight = false;
            }
        }
    }
}
