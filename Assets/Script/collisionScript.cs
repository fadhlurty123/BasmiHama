using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider col)
    {
        GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy(explostion, 2);

        if (GameObject.FindGameObjectWithTag("Player").Length == 0)
        {
            GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
            GameObject enemy1 = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
            GameObject enemy2 = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
            GameObject enemy3 = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
        }

        Destroy(gameObject);
    }
}
