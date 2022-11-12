using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_the_path_b44 : MonoBehaviour
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
        Dice4.posb3 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    
    void Update()
    {
        if (firstmove3 == true && transform.position == firstplace3.position && Dice4.freeblue)
        {
            if (Dice4.posb == 0)
            {
                if(Dice4.posb1!=0 && Dice4.posb2!=0)
                {
                    Dice4.posb3 = 0;
                    if (Dice4.posbLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posbLeft3 = true;
                    }
                }
            }
            else if (Dice4.posb1 == 0)
            {
                if(Dice4.posb!=0 && Dice4.posb2!=0)
                {
                    Dice4.posb3 = 0;
                    if (Dice4.posbLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posbLeft3 = true;
                    }
                }
            }
            else if (Dice4.posb2 == 0)
            {
                if(Dice4.posb!=0 && Dice4.posb1!=0)
                {
                    Dice4.posb3 = 0;
                    if (Dice4.posbLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posbLeft3 = true;
                    }
                }
            }////////////////////////////////////////////////////////ajouter le cas de player yellow
            else
            {
                if(folow_the_path4.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    folow_the_path4.initpos=true;
                }
                else if(folow_the_path14.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    folow_the_path14.initpos=true;
                }
                else if(folow_the_path24.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    folow_the_path24.initpos=true;
                }
                else if(folow_the_path34.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    folow_the_path34.initpos=true;
                }
                else if(follow_the_path_y14.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_y14.initpos=true;
                }
                else if(follow_the_path_y_24.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_y_24.initpos=true;
                }
                else if(follow_the_path_y_34.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_y_34.initpos=true;
                }
                else if(follow_the_path_y_44.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_y_44.initpos=true;
                }
                else if(follow_the_path_g14.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_g14.initpos=true;
                }
                else if(follow_the_path_g24.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_g24.initpos=true;
                }
                else if(follow_the_path_g34.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_g34.initpos=true;
                }
                else if(follow_the_path_g44.x==51)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,4);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,4);
                    }
                    follow_the_path_g44.initpos=true;
                }
                else
                {
                    Dice4.posb3 = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=51;
            if(follow_the_path_b24.firstmove1==false && follow_the_path_b34.firstmove2==false && follow_the_path_b14.firstmove==false) Dice4.freeblue=false;
            firstmove3=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace3.position;
            Dice4.posb3= -1;
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
        if(Dice4.accessblue)
        {
            if (Dice4.posb >= 0)
            {
                if (numberImg4.show == true)
                {
                    numberImg4.hideimg(); numberImg4.show = false;///////////////
                    numberImg14.hideimg(); numberImg14.show = false;//////////////
                    Dice4.selectedb = 0;
                }
                else
                {
                    numberImg4.showimg(); numberImg4.show = true;///////////////
                    numberImg14.showimg(); numberImg14.show = true;/////////////////
                    Dice4.selectedb = 4;
                }
            }    
        }
    }
    IEnumerator move()
    {
        if(Dice4.posb3 + Dice4.nbr == waypoints.Length)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posbLeft = false;
            for (int i =Dice4.posb3;i< Dice4.posb3 + Dice4.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice4.posb3= Dice4.posb3 + Dice4.nbr;
            x=x+ Dice4.nbr;
            transform.position = final4.position;
            if(Dice4.access1==false)
            {
                numberImg4.setimg(10);
                Dice4.access1=Dice4.canaccess(10,4);
            }
            else if(Dice4.access2==false)
            {
                numberImg14.setimg(10);
                Dice4.access2=Dice4.canaccess(10,4);
            }
            Dice4.enterb++;
        }
        else if (Dice4.posb3 + Dice4.nbr <= waypoints.Length - 1)
        {
            numberImg4.hideimg(); numberImg4.show = false;////////////////
            numberImg14.hideimg(); numberImg14.show = false;///////////////////
            Dice4.posbLeft3 = false;
            for (int i =Dice4.posb3 ;i<= Dice4.posb3 + Dice4.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice4.posb3 += Dice4.nbr;
            for(int i=1;i<=Dice4.nbr;i++)
            {
                if(x==68)
                {
                    x=0;x++;
                }
                else if(Dice4.posb3<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice4.posb == Dice4.posb3)
            {
                if (Dice4.posbLeft == true)
                {
                    transform.position = waypoints[Dice4.posb3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posb3].position;
                    Dice4.posbLeft3 = true;
                }
            }
            else if (Dice4.posb1 == Dice4.posb3)
            {
                if (Dice4.posbLeft1 == true)
                {
                    transform.position = waypoints[Dice4.posb3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posb3].position;
                    Dice4.posbLeft3 = true;
                }
            }
            else if (Dice4.posb2 == Dice4.posb3)
            {
                if (Dice4.posbLeft2 == true)
                {
                    transform.position = waypoints[Dice4.posb3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posb3].position;
                    Dice4.posbLeft3 = true;
                }
            }//////////////////////////////////////////////////////////////////ajouter le cas de player yellow
            if(x==folow_the_path4.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                folow_the_path4.initpos=true;
            }
            else if(x==folow_the_path14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                folow_the_path14.initpos=true;
            }
            else if(x==folow_the_path24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                folow_the_path24.initpos=true;
            }
            else  if(x==folow_the_path34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                folow_the_path34.initpos=true;
            }
            else if(x==follow_the_path_y14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_y14.initpos=true;
            }
            else if(x==follow_the_path_y_24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_y_24.initpos=true;
            }
            else if(x==follow_the_path_y_34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_y_34.initpos=true;
            }
            else if(x==follow_the_path_y_44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_y_44.initpos=true;
            }
            else if(x==follow_the_path_g14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_g14.initpos=true;
            }
            else if(x==follow_the_path_g24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_g24.initpos=true;
            }
            else if(x==follow_the_path_g34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_g34.initpos=true;
            }
            else if(x==follow_the_path_g44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,4);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,4);
                }
                follow_the_path_g44.initpos=true;
            }
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
