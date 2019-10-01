﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Processor : MonoBehaviour{
    ANICNTL ANI;

    //customFunc
    //public
    //void
    public void Logger(string Data) {
        //0=Name ,1=Description
        for (int i =0; i<2;i++)
            DataPather.realData[i].GetComponent<Text>().text = Splitter(Data)[i];
    }

    public void Imager(string Data) {
        //0 = type, 1= fileName, 2 = effect, 3 = position(Nullable)
        switch (Splitter(Data)[0].ToLower()) {
            case "bg":
                DataPather.realData[2].GetComponent<Image>().overrideSprite = Resources.Load("Image/BG/" + Splitter(Data)[1]) as Sprite;
                break;
            case "char":
                //데이터를 찾는다. 해당은 3번 이후에서 시작한다.
                //파일이름과 일치하는 데이터가 있는지 찾는다.
                //없으면 add후 실행
                //있으면 해당 스프라이트에서 실행
                
                //DataPather.realData[2].GetComponent<Image>().overrideSprite = Resources.Load("Image/Units/" + Splitter(Data)[1]) as Sprite;
                break;

            default: break;

        }
        //if BackGround...
        //if Character Image...
    }
    public void Audior(string Data) {

    }

    //private
    private string[] Splitter(string Data) {
        string[] parsed= null;
        char[] splitter = { ';' };
        parsed = Data.Split(splitter);

        return parsed;
    }
}