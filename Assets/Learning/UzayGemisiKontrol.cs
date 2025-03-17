using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UzayGemisiKontrol : MonoBehaviour
{
    const float hareketGucu = 5; // Sabit bir hareket g�c� tan�mland�

    bool topluyor = false;

    GameObject hedef;

    Rigidbody2D myRigidbody2D;

    Toplay�c� toplayici; // K���k "i" ile tan�mland�

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<Toplay�c�>(); // K���k "i" ile ayn� �ekilde kullan�ld�
    }

    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTopla();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == hedef)
        {
            toplayici.YildizYokEt(hedef); // Do�ru metod ad�
            myRigidbody2D.velocity = Vector2.zero;
            GitVeTopla();
        }
    }


    void GitVeTopla()
    {
        hedef = toplayici.HedefYildiz; // K���k "i" ile kullan�ld�
        if (hedef != null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            myRigidbody2D.AddForce(gidilecekYer * hareketGucu, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;

        //float yatayInput = Input.GetAxis("Horizontal"); // Unity'de "Horizontal" do�ru girdi ismi

        //if (yatayInput != 0) // != operat�r� aras�ndaki bo�luklar kald�r�ld�
        //{
        //    position.x += yatayInput * hareketGucu * Time.deltaTime;
        //}

        //float dikeyInput = Input.GetAxis("Vertical"); // Unity'de "Vertical" do�ru girdi ismi
        //if (dikeyInput != 0)
        //{
        //    position.y += dikeyInput * hareketGucu * Time.deltaTime;
        //}

        //transform.position = position;
    }
}
