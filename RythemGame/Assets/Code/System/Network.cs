using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class Network : MonoBehaviour{

    public void NetConnect() {
        FacebookINIT();
    }

    //BaceBookSys
    public void FacebookLogOn() {
        if (!FB.IsLoggedIn) FB.LogInWithReadPermissions(new List<string> {"public_profile"},AuthCallback);
    }

    private void FacebookINIT() {
        if (!FB.IsInitialized)FB.Init(FBINITCall, OnHideUnity) ;
        else FB.ActivateApp();
    }

    //FaceBookCallback
    private void FBINITCall() {
        if (FB.IsInitialized)FB.ActivateApp() ;
        else Debug.Log("Failed Connections");
    }
    private void OnHideUnity(bool IsGameShown) {
        if (!IsGameShown) Time.timeScale = 0 ;
        else Time.timeScale = 1;
    }

    public void AuthCallback(ILoginResult result) {
        //if cancel...
        if (result.Cancelled) {
            Debug.Log("LogInCancelled");
            return;
        }
        //if error...
        if (result.Error != null) {
            Debug.Log(result.Error.ToString());
            //result.Error.GetHashCode();
            return;
        } else {
            var Token = AccessToken.CurrentAccessToken;
            Debug.Log(Token.ToString());
        }
    }
}
