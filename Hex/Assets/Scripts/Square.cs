using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public GameObject BuyMenu;

    // Start is called before the first frame update
    void Start()
    {
        BuyMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        BuyMenu.SetActive(true);
    }

    private void OnMouseExit()
    {
        BuyMenu.SetActive(false);
    }
}
