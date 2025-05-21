using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComidaAnimalitos : MonoBehaviour
{
        public TMP_InputField inputCodigo;
        public TMP_InputField inputCantDias;
        string codigo;
        int comidaPerrosPequeños = 400;
        int comidaPerrosGrandes = 700;
        int comidaGatos = 300;
        int comidaAnimalIndicado;
        int cantComidaTotal;
        float precioPorCienGramos = 80;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CalcularComida()
    {
        if (inputCantDias.text == "" || inputCantDias.text == string.empty) // Dos maneras distintas de escribir lo mismo
        {
            textResultado.text = "Debe ingresar una cantidad de dias";
            return;
        }
        if (inputcodigo.text == "" || inputcodigo.text == string.empty)
        {
            textResultado.text = "Debe ingresar un codigo";
            return;
        }

        codigo = inputCodigo.text;
        cantDias = int.Parse(inputCantDias.text);

        if(cantDias <3)
        {
            txtResultado.text = "La cantidad de dias debe ser mayor a 3";
            return;
        }

        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            txtResultado.text = "El codigo ingresado no es correcto";
            return;
        }

        if (codigo == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        }

        else if(codigo == "PG")
        {
            comidaAnimalIndicado = comidaPerrosGrandes;
        }

        else if(codigo == "PP")
        {
            comidaAnimalIndicado = comidaPerrosPequeños;
        }

        cantComidaTotal =  comidaAnimalIndicado * cantDias;
        precioTotal = (cantComidaTotal / 100) * precioPorCienGramos
        txtResultado.text = "Para ese periodo se nesecitan " +  cantComidaTotal + "gramos de alimento, que saldrán $" + precioTotal;
    }
}
