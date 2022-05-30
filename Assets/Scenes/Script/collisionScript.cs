using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

     void OnTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("energyBlast", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explosion, 2);


        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


            /*            GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
                        GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
                        GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;*/

        }

        Destroy(gameObject);


    }



}
