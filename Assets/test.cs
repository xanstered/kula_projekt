using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SocialPlatforms;
using TMPro;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public float amountCoins = 0; //zmienna na monety
    public TextMeshProUGUI coinTxt; // zmienna do tekstu zwi¹zana z punktami, które pojawiaj¹ sie na ekranie
    private int HP = 3; //nwm

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //postaæ idzie do przodu
        {
            transform.Translate(Vector3.forward * 0.005f);
        }
        if (Input.GetKey(KeyCode.S)) //postaæ idzie do ty³u
        {
            transform.Translate(Vector3.back * 0.005f);
        }
        if (Input.GetKey(KeyCode.A)) //postaæ idzie w lewo
        {
            transform.Translate(Vector3.left * 0.005f);
        }
        if (Input.GetKey(KeyCode.D)) //postaæ idzie w prawo
        {
            transform.Translate(Vector3.right * 0.005f);
        }
        if (Input.GetKey(KeyCode.Space)) //postaæ wznosi siê
        {
            transform.Translate(Vector3.up * 0.005f);
        }
        if (Input.GetKey(KeyCode.Z)) //postaæ obni¿a siê
        {
            transform.Translate(Vector3.down * 0.005f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) //dodaje siê tag na monety
        {
            other.gameObject.SetActive(false); //nwm
            amountCoins = amountCoins + 1; //liczba monet siê zwiêksza wraz z zdobyciem nowej monety
            coinTxt.text = amountCoins.ToString(); ; //zmienia liczbê zdobytych monet na ekranie
        }
        if (other.gameObject.CompareTag("Size")) //dodaje tag na zmianê roziaru postaci
        {
            transform.localScale += new Vector3(5f, 5f, 5f);
        }
        if (other.gameObject.CompareTag("Door") && amountCoins >= 3) //dodaje tag do drzwi oraz warunek ich otworzenia
        {
            other.GetComponent<Animator>().SetTrigger("Door"); //animacja drzwi??
        }
        if (other.gameObject.CompareTag("End")) //dodaje tag, który umo¿liwia nam przejœcie do nastêpnego levelu
        {
            SceneManager.LoadScene(1); // ³adowanie sceny?
        }

        if (other.gameObject.CompareTag("Dead")) // dodaje tag, który sprawia ¿e nasza postaæ umiera
        {
            //HP.currenthP--;
            //txtHP.text = HP.currenthP.ToString();

            //if (HP.currenthP <= 0)
            //{
            //    HP.currenthP = 3;
            //    SceneManager.LoadScene(0);
            //}
        }

        //if (HP > 0) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReduceCoin(int p) //redukuje zdobyte monety je¿eli wyda³o siê je w sklepie
    {
        amountCoins -= p; // coœ zwi¹zanego ze sklepem...
        coinTxt.text = amountCoins.ToString(); // pokazuje iloœæ monet na ekranie
    }
}


