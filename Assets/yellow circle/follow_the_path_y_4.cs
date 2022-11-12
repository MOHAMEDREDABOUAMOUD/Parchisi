using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow_the_path_y_4 : MonoBehaviour
{
    //[SerializeField] private GameObject dest;
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace3;
    [SerializeField] Transform final4;
    [SerializeField] public static Transform curentpos;
    public static bool allowMove3 = false,firstmove3=false;
    public static bool click =false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = firstplace3.position;
        Dice.posy3 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    
    void Update()
    {
        if (firstmove3 == true && transform.position == firstplace3.position && Dice.freeyellow)
        {
            if (Dice.posy == 0)
            {
                if(Dice.posy1!=0 && Dice.posy2!=0)
                {
                    Dice.posy3 = 0;
                    if (Dice.posyLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posyLeft3 = true;
                    }
                }
            }
            else if (Dice.posy1 == 0)
            {
                if(Dice.posy!=0 && Dice.posy2!=0)
                {
                    Dice.posy3 = 0;
                    if (Dice.posyLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posyLeft3 = true;
                    }
                }
            }
            else if (Dice.posy2 == 0)
            {
                if(Dice.posy!=0 && Dice.posy1!=0)
                {
                    Dice.posy3 = 0;
                    if (Dice.posyLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posyLeft3 = true;
                    }
                }
            }
            else
            {
                if(folow_the_path.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    folow_the_path.initpos=true;
                }
                else if(folow_the_path1.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    folow_the_path1.initpos=true;
                }
                else if(folow_the_path2.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    folow_the_path2.initpos=true;
                }
                else if(folow_the_path3.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    folow_the_path3.initpos=true;
                }
                else if(follow_the_path_g1.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    follow_the_path_g1.initpos=true;
                }
                else if(follow_the_path_g2.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    follow_the_path_g2.initpos=true;
                }
                else if(follow_the_path_g3.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    follow_the_path_g3.initpos=true;
                }
                else if(follow_the_path_g4.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,2);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,2);
                    }
                    follow_the_path_g4.initpos=true;
                }
                else
                {
                    Dice.posy3 = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=34;
            if(follow_the_path_y_2.firstmove1==false && follow_the_path_y_3.firstmove2==false && follow_the_path_y1.firstmove==false) Dice.freeyellow=false;
            firstmove3=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace3.position;
            Dice.posy3= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace3.position)
        {
            StartCoroutine(move());
            click = false;
        }
    }
    private void OnMouseDown()
    {
        if(Dice.accessyellow)
        {
            if (Dice.posy >= 0)
            {
                if (numberImg.show == true)
                {
                    numberImg.hideimg(); numberImg.show = false;///////////////
                    numberImg1.hideimg(); numberImg1.show = false;//////////////
                    Dice.selectedy = 0;
                }
                else
                {
                    numberImg.showimg(); numberImg.show = true;///////////////
                    numberImg1.showimg(); numberImg1.show = true;/////////////////
                    Dice.selectedy = 4;
                }
            }    
        }
    }
    IEnumerator move()
    {
        if(Dice.posy3 + Dice.nbr == waypoints.Length)
        {
            numberImg.hideimg();numberImg.show = false;////////////////
            numberImg1.hideimg();numberImg1.show = false;///////////////////
            Dice.posyLeft = false;
            for (int i =Dice.posy3;i< Dice.posy3 + Dice.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice.posy3= Dice.posy3 + Dice.nbr;
            x=x+ Dice.nbr;
            transform.position = final4.position;
            if(Dice.access1==false)
            {
                numberImg.setimg(10);
                Dice.access1=Dice.canaccess(10,2);
            }
            else if(Dice.access2==false)
            {
                numberImg1.setimg(10);
                Dice.access2=Dice.canaccess(10,2);
            }
            Dice.entery++;
        }
        else if (Dice.posy3 + Dice.nbr <= waypoints.Length - 1)
        {
            numberImg.hideimg(); numberImg.show = false;////////////////
            numberImg1.hideimg(); numberImg1.show = false;///////////////////
            Dice.posyLeft3 = false;
            for (int i =Dice.posy3 ;i<= Dice.posy3 + Dice.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice.posy3 += Dice.nbr;
            for(int i=1;i<=Dice.nbr;i++)
            {
                if(x==68)
                {
                    x=0; x++;
                }
                else if(Dice.posg3<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice.posy == Dice.posy3)
            {
                if (Dice.posyLeft == true)
                {
                    transform.position = waypoints[Dice.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posy3].position;
                    Dice.posyLeft3 = true;
                }
            }
            else if (Dice.posy1 == Dice.posy3)
            {
                if (Dice.posyLeft1 == true)
                {
                    transform.position = waypoints[Dice.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posy3].position;
                    Dice.posyLeft3 = true;
                }
            }
            else if (Dice.posy2 == Dice.posy3)
            {
                if (Dice.posyLeft2 == true)
                {
                    transform.position = waypoints[Dice.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posy3].position;
                    Dice.posyLeft3 = true;
                }
            }
            if(x==folow_the_path.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                folow_the_path.initpos=true;
            }
            else if(x==folow_the_path1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                folow_the_path1.initpos=true;
            }
            else if(x==folow_the_path2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                folow_the_path2.initpos=true;
            }
            else  if(x==folow_the_path3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                folow_the_path3.initpos=true;
            }
            else if(x==follow_the_path_g1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                follow_the_path_g1.initpos=true;
            }
            else if(x==follow_the_path_g2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                follow_the_path_g2.initpos=true;
            }
            else if(x==follow_the_path_g3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                follow_the_path_g3.initpos=true;
            }
            else if(x==follow_the_path_g4.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,2);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,2);
                }
                follow_the_path_g4.initpos=true;
            }
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
