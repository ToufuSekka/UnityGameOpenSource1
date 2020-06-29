using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer {
    private float Speeds = 0.0f, Clock_192s = 0.0f, Clock = 0.0f, Tempo = 0;
    int Line = 0;

    bool setter= false;
    public Timer(float tempo) {
        Tempo = tempo;
        Speeds = (tempo*192) / 60;
    }

    public Timer(float StartDel,float tempo) {
        Tempo = tempo;
        Clock = StartDel;
        Speeds = (tempo* 192) / 60;
    }

    private void run(bool set) {
        if (!set) return;

        if (Clock_192s > 192) {
            Clock_192s = 0;
            Clock++;
        }
        if (Clock > 3) {
            Clock = 0;
            Line++;
        }
        Clock_192s += Time.deltaTime* Speeds;
    }

    public void StartTimer() {
        setter = true;
        run(setter);
    }

    public void StopTimer() {
        setter = false;
        run(setter);
    }

    public void ResetTimer() {
        Speeds = 0.0f;
        Clock_192s = 0.0f;
    }

    public int getTimeData(int TimeType) {
        switch (TimeType) {
            case 1:
                return Line;
            case 2:
                return (int)Clock;
            case 3:
                return (int)Clock_192s;
        }
        return 0;
    }

    public string getClock() {
        string clocks = "";
        clocks = Line.ToString("N0")+":"+ Clock.ToString("N0")+"."+ Clock_192s.ToString("N0");
        return clocks;
    }

    public int getTempo() {
        return (int) Tempo;
    }
}
