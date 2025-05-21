using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public TextMeshProUGUI txtAnswer;
    int answer;
    int numberA;
    int numberB;

    // Start is called before the first frame update
    void Start()
    {
        txtAnswer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OperationAndResult()
    {
        numberA = int.Parse(inputA.text);
        numberB = int.Parse(inputB.text);
        answer = numberA + numberB;
        txtAnswer.text = "La suma entre " + numberA + " y " + numberB + " y el resultado es " + answer;
    }
}
