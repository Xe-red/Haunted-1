using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd_2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You Lose");
        }
    }
}
