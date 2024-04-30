using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;
public class WebGlKeyboard : MonoBehaviour
{
    public TMP_InputField InputField;
    // Start is called before the first frame update
    [DllImport("__Internal")]
    private static extern string Hello();

    [DllImport("__Internal")]
    private static extern string Blur();

    [DllImport("__Internal")]
    private static extern bool Check();

    [DllImport("__Internal")]
    private static extern bool LastValue(string value);

    public bool Focus;
    public bool IsMobile = false;
    string LastStoreValue;


    private void Start()
    {
        if (Check())
        {
            IsMobile = true;
        }

        if (!IsMobile)
        {
            Destroy(this);
        }
    }



    public void CreateInputBox(TMP_InputField input)
    {

        InputField = input;
        LastValue(input.text);
        Focus = true;
        
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Focus && InputField != null)
        {

            InputField.text = Hello();
        }
    }


    public  void RemoveInputBox()
    {
        

        Focus = false;
        InputField = null;
        Blur();
        
    }
}
