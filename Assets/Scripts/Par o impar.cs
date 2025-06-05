using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Paroimpar : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TextMeshProUGUI textParOImpar;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        textParOImpar.text = string.Empty;
    }

    public void EsParOEsImpar()
    {
        if (inputNum1.text == "")
        {
            textParOImpar.text = "El campo esta vacio";
        }
        num1 = int.Parse(inputNum1.text);

        if(num1 <= 0)
        {
            textParOImpar.text = "El numero debe ser mayor que cero";
        }

        if (num1 % 2 == 0)
        {
            textParOImpar.text = "El numero proporcionado es par";
        }

        else {
            textParOImpar.text = "El numero proporcionado es impar";
        }
    }
}
