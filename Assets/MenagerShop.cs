using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenagerShop : MonoBehaviour
{
    [SerializeField] private GameObject _shop; // zmienna do sklepu 
    [SerializeField] private GameObject _hat1; // zmienna do czapki nr 1 
    [SerializeField] private GameObject _hat2; // zmienna do czapki nr 2 

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //otworzenie sklepu za pomoc¹ klawisza P
        {
            _shop.SetActive(!_shop.activeInHierarchy); // coœ do aktywowania sklepu?
        }
    }
    public void hat1() // dodanie czapki nr 1 do sklepu

    {
        if (GetComponent<test>().amountCoins >= 3) //mo¿liwoœæ kupienia czapki jeœli spe³ni siê warunek
            _hat1.SetActive(true); // kupienie czapki nr 1
        _hat2.SetActive(false); // nie kupienie czapki nr 2
    }
    public void hat2() // dodanie czapki nr 2 do sklepu
    {
        if (GetComponent<test>().amountCoins >= 3) //mo¿liwoœæ kupienia czapki jeœli spe³ni siê warunek
            _hat2.SetActive(true); // kupienie czapki nr 2
        _hat1.SetActive(false); // nie kupienie czapki nr 1
    }
}
   
