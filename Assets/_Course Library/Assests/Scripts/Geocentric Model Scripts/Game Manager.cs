using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isDailyMotion;
    public static GameManager Instance;
    public bool shouldRotate;
    public bool onlyManda;
    public bool withoutMandaShigra;
    private GameObject title;
    private GameObject dailyMotionButton;
    private GameObject yearlyMotionButton;
    private GameObject options;
    public GameObject mandaToggle;
    public GameObject sigraToggle;
    public GameObject backButton;
    public Toggle mandaToggleComponent;
    public Toggle sigraToggleComponent;
    public GameObject homeCanvas;
    public GameObject dailyMotionIntro;
    public GameObject yearlyMotionIntro;
    // Start is called before the first frame update
    void Start()
    {
        Instance=this;
        DontDestroyOnLoad(gameObject);
        
        
        
        title=GameObject.Find("Title");
        dailyMotionButton=GameObject.Find("Daily Motion Button");
        yearlyMotionButton=GameObject.Find("Yearly Motion");
        options=GameObject.Find("Options");
        // mandaToggleComponent=mandaToggle.GetComponent<Toggle>();
        // sigraToggleComponent=sigraToggle.GetComponent<Toggle>();
        // mandaToggle=GameObject.Find("Manda Toggle");
        // sigraToggle=GameObject.Find("Sigra Toggle");
        // backButton=GameObject.Find("Back Button");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartDailyMotion(){
        SceneManager.LoadScene("Daily Motion");
        }
    public void StartYearlyMotion(){
        SceneManager.LoadScene("Yearly Motion");
        }

    public void Options(){
        title.SetActive(false);
        dailyMotionButton.SetActive(false);
        yearlyMotionButton.SetActive(false);
        options.SetActive(false);
        mandaToggle.SetActive(true);
        sigraToggle.SetActive(true);
        backButton.SetActive(true);
    }
    public void Back(){
        title.SetActive(true);
        dailyMotionButton.SetActive(true);
        yearlyMotionButton.SetActive(true);
        options.SetActive(true);
        mandaToggle.SetActive(false);
        sigraToggle.SetActive(false);
        backButton.SetActive(false);
    }
    public void MandaToggle(){
        if(mandaToggleComponent.isOn/*true*/ && !sigraToggleComponent.isOn/*false*/){
            withoutMandaShigra=false;
            onlyManda=true;
        }
        else if(mandaToggleComponent.isOn/*true*/ && sigraToggleComponent.isOn/*true*/){
            onlyManda=false;
            withoutMandaShigra=false;
        }
        else if(!mandaToggleComponent.isOn/*true*/ && sigraToggleComponent.isOn /*false*/){
            onlyManda=false;
            withoutMandaShigra=true;
            sigraToggleComponent.isOn=false;
        }
        else{
            withoutMandaShigra=true;
            sigraToggleComponent.isOn=false;
            onlyManda=false;
        }
    }
    public void SigraToggle(){
        if(sigraToggleComponent.isOn /*true*/&& mandaToggleComponent.isOn/*true*/){
            withoutMandaShigra=false;
            onlyManda=false;
        }
        else if(sigraToggleComponent.isOn/*true*/ && !mandaToggleComponent.isOn /*false*/){
            sigraToggleComponent.isOn=false;
            withoutMandaShigra=true;
            onlyManda=false;
        }
        else if(!sigraToggleComponent.isOn/*false*/ && mandaToggleComponent.isOn/*true*/){
            withoutMandaShigra=false;
            onlyManda=true;
        }
        else{
            onlyManda=false;
            withoutMandaShigra=true;
        }
    }
    public void Home(){
        SceneManager.LoadScene("Home Screen");
    }
    public void continueButton(){
        SceneManager.LoadScene("Home Screen");
    }
    public void DailyMotionButton(){
        homeCanvas.SetActive(false);
        dailyMotionIntro.SetActive(true);
    }
    public void YeralyMotionButton(){
        homeCanvas.SetActive(false);
        yearlyMotionIntro.SetActive(true);
    }
}


