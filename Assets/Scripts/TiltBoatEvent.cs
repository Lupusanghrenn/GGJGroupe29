using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltBoatEvent : MonoBehaviour
{
    public enum RotateDirection { None, Left, Right, Front, Back };
    public RotateDirection rotateDirection;
    private RotateDirection previousDirection;

    private bool mustResetRotation = false;

    public float maxAngle;
    public float rotationSpeed;
    public float timeToWaitOnAngle;

    public float boatAngleX;
    public float boatAngleZ;

    IEnumerator ResetBoatAngleTimer()
    {
        yield return new WaitForSeconds(timeToWaitOnAngle);
        mustResetRotation = true;
    }

    void Update()
    {
        boatAngleX = (this.transform.eulerAngles.x > 180) ? this.transform.eulerAngles.x - 360 : this.transform.eulerAngles.x;
        boatAngleZ = (this.transform.eulerAngles.z > 180) ? this.transform.eulerAngles.z - 360 : this.transform.eulerAngles.z;


        if (rotateDirection == RotateDirection.Right)
        {
            if (boatAngleX <= maxAngle)
            {
                transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                StartCoroutine(ResetBoatAngleTimer());
                previousDirection = rotateDirection;
                rotateDirection = RotateDirection.None;
            }
        }

        if (rotateDirection == RotateDirection.Left)
        {
            if (boatAngleX >= -maxAngle)
            {
                transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
            }
            else
            {
                StartCoroutine(ResetBoatAngleTimer());
                previousDirection = rotateDirection;
                rotateDirection = RotateDirection.None;
            }
        }

        if (rotateDirection == RotateDirection.Front)
        {
            if (boatAngleZ <= maxAngle)
            {
                transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            }
            else
            {
                StartCoroutine(ResetBoatAngleTimer());
                previousDirection = rotateDirection;
                rotateDirection = RotateDirection.None;
            }
        }

        if (rotateDirection == RotateDirection.Back)
        {
            if (boatAngleZ >= -maxAngle)
            {
                transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            }
            else
            {
                StartCoroutine(ResetBoatAngleTimer());
                previousDirection = rotateDirection;
                rotateDirection = RotateDirection.None;
            }
        }



        if (rotateDirection == RotateDirection.None && mustResetRotation)
        {
            if(previousDirection == RotateDirection.Right)
            {
                if (Mathf.RoundToInt(boatAngleX) != 0)
                {
                    transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.eulerAngles = Vector3.zero;
                    previousDirection = RotateDirection.None;
                    mustResetRotation = false;
                }
            }
            if (previousDirection == RotateDirection.Left)
            {
                if (Mathf.RoundToInt(boatAngleX) != 0)
                {
                    transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
                }
                else
                {
                    transform.eulerAngles = Vector3.zero;
                    previousDirection = RotateDirection.None;
                    mustResetRotation = false;
                }
            }

            if (previousDirection == RotateDirection.Front)
            {
                if (Mathf.RoundToInt(boatAngleZ) != 0)
                {
                    transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
                }
                else
                {
                    transform.eulerAngles = Vector3.zero;
                    previousDirection = RotateDirection.None;
                    mustResetRotation = false;
                }
            }
            if (previousDirection == RotateDirection.Back)
            {
                if (Mathf.RoundToInt(boatAngleZ) != 0)
                {
                    transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
                }
                else
                {
                    transform.eulerAngles = Vector3.zero;
                    previousDirection = RotateDirection.None;
                    mustResetRotation = false;
                }
            }
        }
    }
}
