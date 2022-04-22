using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLinks : MonoBehaviour
{
    public void LinkDin(){
        Application.OpenURL("https://www.linkedin.com/in/shreya-sethi-3a6164228/");
    }
   
    public void Twitter(){
        Application.OpenURL("https://twitter.com/home");
    }

    public void Instagram(){
        Application.OpenURL("https://www.instagram.com/shreyasethi22/");
    }

    public void Discord(){
        Application.OpenURL("https://discord.com/");
    }

    public void YouTube(){
        Application.OpenURL("https://www.youtube.com/channel/UCyVkEzNPg_F53_Ba3YL1kVw");
    }

    public void GitHub(){
        Application.OpenURL("https://github.com/SethiShreya");
    }
}
