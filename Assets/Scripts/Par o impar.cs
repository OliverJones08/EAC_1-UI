using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Paroimpar : MonoBehaviour
{
    public TMP_InputField imputnum1;
    public TextMeshProUGUI txtParOImpar;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        txtParOImpar.text = string.Empty;
    }

    public void EsParOEsImpar()
    {
        if (inputNum1.text == "")
        {
            txtParOImpar.text = "El campo esta vacio";
        }
        num1 = int.Parse(inputNum1.text);

        if(num1 <= 0)
        {
            txtParOImpar.text = "El numero debe ser mayor que cero";
        }

        if (num1 % 2 == 0)
        {
            txtParOImpar.text = "El numero proporcionado es par";
        }

        else {
            txtParOImpar.text = "El numero proporcionado es impar";
        }
    }
}
