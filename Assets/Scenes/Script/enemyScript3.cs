using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("Move");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * 20f * Time.deltaTime);
    }

    IEnumerator Move()
    {


        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            transform.eulerAngles += new Vector3(0, 90f, 0);
        }
    }
}
