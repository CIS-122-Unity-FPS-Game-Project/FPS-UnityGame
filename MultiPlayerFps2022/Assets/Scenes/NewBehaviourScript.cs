using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    //public float number = 3;

    // Start is called before the first frame update
     void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
