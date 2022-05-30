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

        transform.Translate(Vector3.right * 10f * Time.deltaTime);
    }

    IEnumerator Move()
    {


        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            transform.eulerAngles += new Vector3(0, 180f, 0);
        }
    }
}
