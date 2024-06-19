using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySwitcher : MonoBehaviour
{
    public GameObject[] foods;
    public int index;
    
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        Instantiate(foods[index],transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Prueba");
 
            index += 1;
            Instantiate(foods[index], transform.position, Quaternion.identity);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Prueba");
   
            index -= 1;
            Instantiate(foods[index], transform.position, Quaternion.identity);

        }
    }

}
