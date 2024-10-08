using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksMenuOpening : MonoBehaviour
{
    public GameObject QuestMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            if(QuestMenu.activeInHierarchy)
            {
            QuestMenu.SetActive(false);
            }
            else
            {
            QuestMenu.SetActive(true);
            }
        }
    
    }
}
