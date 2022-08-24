using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WatchForKeyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            Debug.Log("just touched the key to the door!");

            Debug.Log("trying to switch scenes now");
            SceneManager.LoadScene(1);
        }
    }
}
