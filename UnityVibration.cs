using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    public static Vibration instance;
    private AndroidJavaObject androidVibrator;
    [SerializeField] private bool vibrationMasterState=false;        //기본값 False
    
    public bool VibrateActiveMode { get { return vibrationMasterState; } set { vibrationMasterState = value; } }

    private void Awake() {
        androidVibrator = new AndroidJavaObject("com.Resetframe.Sample.UnityVibration");
    }

    //나중에 필요할때 해당 코드 바꿔서 사용.
    public bool VibrateActive() {
        if (vibrationMasterState == true) {
            Handheld.Vibrate();
            return true;
        }
        else {
            return false;
        }
    }
    //안드로이드 전용 시간 조작형 진동 메소드. 필요시 사용. 시간단위 : ms (1000 = 1초)
    public bool AndroidVibrator(long length) {
        if (vibrationMasterState == true) {
            androidVibrator.Call("Vibration", length);
            return true;
        }
        else {
            return false;
        }
    }
}
