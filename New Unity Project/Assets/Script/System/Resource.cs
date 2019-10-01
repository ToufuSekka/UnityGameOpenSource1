using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


enum ResourceType : int {
    Money=0,
    Population=1,
    Supply=2,
    Order=3
}

public class Resource : MonoBehaviour {
	public int Money = 0, Population = 0, Supply = 0, Order = 0;
    Text Pub;

    void Respublicer() {
        this.Money = 999999;
        this.Population = 500;
        this.Supply = 200;
        this.Order = 100;

        for (int i = 0; i < 4; i++) {
            Pub = GameObject.Find((ResourceType)i + "_Now").GetComponent<Text>();
            switch (i) {
                case 0:
                    Pub.text = this.Money.ToString();
                    break;
                case 1:
                    Pub.text = this.Population.ToString();
                    break;
                case 2:
                    Pub.text = this.Supply.ToString();
                    break;
                case 3:
                    Pub.text = this.Order.ToString();
                    break;
            }
        }
    }

    void Start() {
        Respublicer();
    }
}