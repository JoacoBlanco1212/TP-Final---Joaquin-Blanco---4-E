using UnityEngine;

public class ArraySwitcher : MonoBehaviour
{
    public GameObject[] foods;
    public int index;
    
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        for (int i = index; i < foods.Length; i++)
        { 
            foods[index].SetActive(false);
            index++;
        }
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Prueba mas");
            DeasctivateAll();
            index += 1;
            foods[index].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Prueba menos");
           
            DeasctivateAll();
            index -= 1;
            foods[index].SetActive(true);
        }
    }

    void DeasctivateAll()
    {
        for (int i = 0; i < foods.Length; i++)
        {
            int deactivateIndex = i;
            foods[deactivateIndex].SetActive(false);
        }
    }

}
