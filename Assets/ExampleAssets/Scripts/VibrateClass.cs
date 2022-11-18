using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class VibrateClass : MonoBehaviour
{
    GameObject textgame;
    GameObject buttonToHide1;
    GameObject buttonToHide2;
    GameObject buttonToHide3;
    private Text text;
    int [] level1Stars = new int[5];
    int [] level1StarsCheck = new int[5];
    int valuetoAttribute = 0;
    
   public Text TextTop;
    int counter = 0;
    int oldcounter = 0;

    float pressure;

    int fingerCount;
    int sbo3 =0;
    // Start is called before the first frame update

     void Start ()
    {
        Vibration.Init ();
        // level1Stars = {Random.Range(1, 3),Random.Range(1, 3),Random.Range(1, 3),Random.Range(1, 3),Random.Range(1, 3)};
        level1Stars[0] = Random.Range(1, 4) ;
        level1Stars[1] = Random.Range(1, 4);
        level1Stars[2] = Random.Range(1, 4);
        level1Stars[3] = Random.Range(1, 4);
        level1Stars[4] = Random.Range(1, 4);
        //Debug.Log(" check hedhy vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
          // TextTop = GetComponent<UnityEngine.UI.Text>().text= counter.ToString();
          buttonToHide1 = GameObject.Find("VibrateButton");
          buttonToHide2 = GameObject.Find("VibrateMetwasset");
          buttonToHide3 = GameObject.Find("VibrateButtonTwila");

          buttonToHide1.SetActive(false);
          buttonToHide2.SetActive(false);
          buttonToHide3.SetActive(false);


          TextTop = GameObject.Find("TextTop").GetComponent<Text>();
            TextTop.text="start";
            


        
        foreach (int val in level1Stars)
        {
            Debug.Log(val);
            if(val == 1){
                Vibration.VibratePop();
            }
            if(val == 2){
                Handheld.Vibrate();
            }
            if(val == 3){
                Vibration.Vibrate ();
            }
        }


        // Debug.Log(level1Stars[1].ToString());
        // Debug.Log(level1Stars[2].ToString());
    }
    public void Vibrate()
    {  
       
        
        Debug.Log("vibration0  : " +level1Stars[0].ToString()+ " vibration 1  : " +level1Stars[1].ToString()+ " vibration 2  : "+level1Stars[2].ToString()+ " vibration 3 : " +level1Stars[3].ToString()+ " vibration 4 : " +level1Stars[4].ToString());
        // this.textgame = GameObject.Find("textgame"); 
        // textgame.AddComponent<Text>();
        // text = textgame.GetComponent<Text>();
        // text.text ="aaaaaaaa";
    }

  

    public void Vibration9sira(){
        if(counter == 5){
            Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
        }
        
        if(counter < 5 && fingerCount == 1){
        //Vibration.VibratePop();
        Handheld.Vibrate();
        level1StarsCheck[counter]=1;
        counter ++;
        TextTop.text="text";
        }
        
        // Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
         
    }
    public void VibrationMetwasta(){
        if(counter == 5 ){
            Debug.Log(" check hedhy vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
            TextTop.text="text";
        }
        if(counter < 5 && fingerCount == 2){
             Handheld.Vibrate();
        level1StarsCheck[counter]=2;
        counter ++;
        }
       
        //Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
    }
    public void VibrationTwila(){
        if(counter == 5 ){
            Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
        }
        if(counter < 5 && fingerCount == 3){
            Vibration.Vibrate ();
        level1StarsCheck[counter]=3;
        counter ++;
        }
        
       //Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
    }

    // void Update(){
    //     if(Input.stylusTouchSupported){
    //         pressure = Pointer.current.pressure.clampConstant;
    //     }
    //     Debug.Log(pressure);
    // }

    void Update()
    {
        fingerCount = 0;
        
        
        //counter = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
               // counter ++;
               // Debug.Log("el counter "+counter);
               sbo3 = fingerCount;
                
            }
            if (touch.phase == TouchPhase.Ended  && counter < 5)
            {
                
                
                Debug.Log("el counter "+counter);
                Debug.Log("el fingerCount "+fingerCount);
                if(sbo3 == 1){
                    valuetoAttribute = 1;
                    Vibration.VibratePop();
                    level1StarsCheck[counter]=1;
                }
                if(sbo3 == 2){
                    valuetoAttribute = 2;
                    counter = counter - 1;
                    Handheld.Vibrate();
        level1StarsCheck[counter]=2;
                }
                if(sbo3 == 3){
                    valuetoAttribute = 3;
                    counter = counter - 2;
                    Vibration.Vibrate ();
        level1StarsCheck[counter]=3;
                }
                if(counter == 4){
            //Debug.Log("vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
            Debug.Log(" check hedhy vibration0  : " +level1StarsCheck[0].ToString()+ " vibration 1  : " +level1StarsCheck[1].ToString()+ " vibration 2  : "+level1StarsCheck[2].ToString()+ " vibration 3 : " +level1StarsCheck[3].ToString()+ " vibration 4 : " +level1StarsCheck[4].ToString());
            //TextTop.text="kamalna";
            if(EqualityOperator(level1Stars,level1StarsCheck) == true){
                TextTop.text = "You won";
            }
             if(EqualityOperator(level1Stars,level1StarsCheck) == false){
                TextTop.text = "You lost";
            }
            
        }
        counter = counter +1;
                
            }
            
        }
        
    }

    public bool EqualityOperator(int[] firstArray, int[] secondArray)
{
    return firstArray == secondArray;
}

    // public void HandheldVib(){
    //    Handheld.Vibrate();
    // }
    // public void TapVibrate ()
    // {
    //     Vibration.Vibrate ();
    // }
/*
    public void TapVibrateCustom ()
    {
        Vibration.Vibrate ( int.Parse ( inputTime.text ) );
    }
    */

    

    // public void TapCancelVibrate ()
    // {

    //     Vibration.Cancel ();
    // }

    // public void TapPopVibrate ()
    // {
    //     Vibration.VibratePop ();
    // }

    // public void TapPeekVibrate ()
    // {
    //     Vibration.VibratePeek ();
    // }

    // public void TapNopeVibrate ()
    // {
    //     Vibration.VibrateNope ();
    // }
    
}
