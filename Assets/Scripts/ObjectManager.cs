using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject human;
    [SerializeField] float value;
    [SerializeField] Vector3 sizeChangeValue;
    private Vector3 startPosition;


    public void Start()
    {
        startPosition = new Vector3(human.transform.position.x, human.transform.position.y, human.transform.position.z);
        sizeChangeValue = new Vector3(0.2f, 0.2f, 0.06f);

    }

    public void MoveUp()
    {

        value = value + 0.5f;


        human.transform.position = new Vector3(human.transform.position.x, human.transform.position.y + value, human.transform.position.z);


    }

    public void MoveDown()
    {
                value = value - 0.5f;


        human.transform.position = new Vector3(human.transform.position.x, human.transform.position.y - value, human.transform.position.z);


    }

    public void MoveLeft()
    {
        value = value - 0.5f;
        human.transform.position = new Vector3(human.transform.position.x - value, human.transform.position.y, human.transform.position.z);
    }


    public void MoveRight()
    {
        value = value + 0.5f;
        human.transform.position = new Vector3(human.transform.position.x + value, human.transform.position.y, human.transform.position.z);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 0.5f, 0f);
    }

    public void RotateRight()
    {
        human.transform.Rotate(0, -0.5f, 0);
    }

    public void RotateBack()
    {
        human.transform.Rotate(20f, 0, 0);
    }

    public void RotateFront()
    {
        human.transform.Rotate(-20f, 0, 0);
    }

    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChangeValue;
    }

    public void Shrink()
    {
        human.transform.localScale = human.transform.localScale - sizeChangeValue;
    }

    public void ResetObject2()
    {
        human.transform.position = new Vector3(0, 0, 0);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }

    public void ResetObject()
    {
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = sizeChangeValue;
        human.transform.position = startPosition;

    }
}
