using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Facebook.Unity;

public class NewBehaviourScript : MonoBehaviour{
    //LogOn Testings

    //UnityCallback
    private void Awake() {
        if (!FB.IsInitialized) {
            FB.Init(FBINIT, OnHideUnity);
            Debug.Log("Success INIT");
        } else FB.ActivateApp();
    }

    //FaceBookCallback
    void FBINIT() {
        if (FB.IsInitialized) FB.ActivateApp();
        else Debug.Log("INIT Failed!");
    }
    void OnHideUnity(bool isGameShown) {
        if (!isGameShown) Time.timeScale = 0;
        else Time.timeScale = 1;
    }

    void AuthCallback(ILoginResult result) {
        var Token = AccessToken.CurrentAccessToken;

        if (result.Error == null) Debug.Log(Token.ToString());
        else Debug.Log("Failed LogIn : " + result.Error.ToString());
    }

    //custom

    public void Clicked() {
        if(!FB.IsLoggedIn)
            FB.LogInWithReadPermissions(new List<string> { "public_profile" }, AuthCallback);
    }
}
