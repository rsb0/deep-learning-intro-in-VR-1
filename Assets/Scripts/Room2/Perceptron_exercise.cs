using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Perceptron_exercise : MonoBehaviour
{
    public GameObject outputPlaceholder;
    public TextMeshProUGUI inputOneText;
    public TextMeshProUGUI inputTwoText;
    public TextMeshProUGUI outputText;
    public TextMeshProUGUI neuronText;
    public Material outputRightAswerMaterial;
    public Material outputWrongAswerMaterial;

    private int inputOne;
    private int inputTwo;
    private int Result;

    private static Color32 WHITE = new Color32(255, 255, 255, 255);
    private static Color32 BLACK = new Color32(0, 0, 0, 255);

    private void Awake()
    {
        this.inputOne = 0;
        this.inputTwo = 0;
        this.Result = 0;
    }

    public void UpdateInputOne(int input)
    {
        this.inputOne = input;
        inputOneText.text = "x1 = " + input.ToString();
    }

    public void UpdateInputTwo(int input)
    {
        this.inputTwo = input;
        inputTwoText.text = "x2 = " + input.ToString();
    }

    public void UpdatePerceptron()
    {
        this.Result = inputOne * 2 + inputTwo;
        neuronText.text = this.inputOne.ToString() + "x2+" + this.inputTwo.ToString() + "x1";

        
        if (Result >= 6)
        {
            outputPlaceholder.GetComponent<MeshRenderer>().material = outputRightAswerMaterial;
            outputText.text = "y = 1";
            outputText.color = BLACK;
        }
        else
        {
            outputPlaceholder.GetComponent<MeshRenderer>().material = outputWrongAswerMaterial;
            outputText.color = WHITE;
            outputText.text = "y = 0";
        }
    }
}
