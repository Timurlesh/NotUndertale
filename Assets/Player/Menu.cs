using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MenuBack;
    private bool Visible = false;
    // Start is called before the first frame update
    void Start()
    {
        MenuBack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MenuOpen()
    {
        if (Visible == true)
        {
            Visible = false;
            MenuBack.SetActive(false);
        }
        else
        {
            Visible = true;
            MenuBack.SetActive(true);
        }
    }
}
