using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AddMachineToHandler : MonoBehaviour
{
    GameObject gameState;

    public Vector3 placementPosition;
    public string interactionType;
    //public string outputType;
    public int interactionTime;

    public GameObject outputObject;
    //public GameObject Object;

    void Awake()
    {
        gameState = GameObject.Find("Game State");

        if (outputObject.name != "Empty")
        {
            //movableObject outputObject = new movableObject(outputTransform.gameObject, outputType);
            gameState.GetComponent<MachineHandler>().RegisterObject(this.gameObject, interactionType, placementPosition, interactionTime, outputObject);

        }
        else
        {
            gameState.GetComponent<MachineHandler>().RegisterObject(this.gameObject, interactionType, placementPosition, interactionTime);
        }


    }
}
