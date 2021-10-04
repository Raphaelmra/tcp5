using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterController : MonoBehaviour
{
    public GameObject Baldinho;
    public GameObject AguaUI;
    public bool temBalde;
    public float health = 10;
    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = Mathf.Clamp(value, 0, healthMax);
        }
    }
    public float healthMax = 10;
    public bool tocou;
    public bool contando;
    public Image healthBar;

    public Text texto;
    public int porcentagem = 100;
    public GameObject textoLago;

    public int porcentagemParaApagarFogo;
    public GameObject textoFogo;
    public Text textoFogoText;
    public bool tentarApagarFogo;

    public GameObject fogo;
    //public AudioSource Dano;
    private void Start()
    {
        Health = 0;
        
    }
    private void Update()
    {
        

      
       

       if(textoLago.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Health = 14;
            }

        }
        if (tentarApagarFogo)
        {
            if (Input.GetKey(KeyCode.F))
            {
                TentarApagarFogo(fogo);
            }
        }
      
       


     
      

       /* if (Input.GetKey(KeyCode.UpArrow))
        {
            Health += 1f;
            porcentagem += 10;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Health -= 1f;
            porcentagem -= 10;

        }*/

        UpdateWaterBar();
        UpdateWaterText();
        if (porcentagem < 0) { Health = 0;  porcentagem = 0; }
    }

    private void UpdateWaterBar()
    {
        healthBar.fillAmount = Health / healthMax;
    }
    private void UpdateWaterText()
    {
        float value = Health / healthMax * 100;
        int value2 = (int)value;
        porcentagem = value2;
        texto.text = value2 + "%";
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "baldinho")
        {
            other.gameObject.SetActive(false);
            Baldinho.SetActive(true);
            AguaUI.SetActive(true);
            temBalde = true;
        }
        if (other.tag == "fogo")
        {


            Health -= 1f;
            
        }
        if (other.tag == "rangeFogo")
        {

            textoFogo.SetActive(true);
            textoFogoText.text = "aperte 'f' para tentar apagar o fogo";
            tentarApagarFogo = true;







        }
        

        if (other.tag == "lago")
        {
            if (temBalde) { textoLago.SetActive(true); }
            
        }
    }
    public void TentarApagarFogo(GameObject fogo)
    {
           
            if (porcentagem >= porcentagemParaApagarFogo)
            {
                fogo.gameObject.SetActive(false);
                textoFogoText.text = "Parabéns, você apagou o fogo";
            }
            else
            {
                textoFogoText.text = "É necessário mais água para apagar esse fogo";
            }
        
    }

    public void OnTriggerExit(Collider other)
    {
        textoLago.SetActive(false);
        textoFogo.SetActive(false);
        tentarApagarFogo = false;

    }



}