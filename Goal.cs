using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class Goal : MonoBehaviour
// {
//     public static bool goal = false;

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             goal = true;
//             Debug.Log("Player reached the goal!");
//         }
//     }
// }
public class Goal : MonoBehaviour
{
    public static bool goal = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goal = true;
            Debug.Log("Player reached the goal!");
        }
    }

    // Optional: You can reset the goal when the object is disabled or reset in another way
    void OnDisable()
    {
        goal = false;
    }
}
