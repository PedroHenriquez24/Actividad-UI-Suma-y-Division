using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PAROIMPAR : MonoBehaviour
{

    public TMP_InputField numeroInput;
    public TextMeshProUGUI txtResultado;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }


    public void verSiEsParOImpar()
    {
        if (numeroInput.text == "")
        {
            txtResultado.text = "El campo está vacío";
            return;
        }

        num1 = int.Parse(numeroInput.text);

        if (num1 < 0)
        {
            txtResultado.text = "El número debe ser mayor a 0";
            return;
        }
        else if (num1 % 2 == 0)
        {
            txtResultado.text = $"{num1} es par";
        }
        else
        {
            txtResultado.text = $"{num1} es impar";
        }
    }
}
