using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIVISORUI : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField InputNum1;
    public TMP_InputField InputNum2;
    public TextMeshProUGUI textResultado;
    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DividirYMostrarResultado()
    {
        num1 = int.Parse(InputNum1.text);
        num2 = int.Parse(InputNum2.text);
        if (num2 != 0)
        {
            textResultado.text = $"{num1 / num2}";
        }
        else
        {
            textResultado.text = "No se puede dividir por 0";
        }
    }

}
