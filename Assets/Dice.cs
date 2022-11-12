using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour
{
    folow_the_path f1;
    public static int tour=1;
    static int finalSide1 = 0;                                                                                                                                                                                                                     
    static int finalSide2 = 0;
    public static int enterr=0,entery=0,enterg=0,p1st=0,p2nd=0,p3th;
    private Sprite[] diceSides; 
    // Array of dice sides sprites to load from Resources folder
    private SpriteRenderer rend;
    public static int pos, pos1, pos2, pos3,posy,posy1,posy2,posy3,posg,posg1,posg2,posg3;
    public static bool posLeft=false, posLeft1=false, posLeft2=false, posLeft3=false,posyLeft=false, posyLeft1=false, posyLeft2=false, posyLeft3=false,posgLeft=false,posgLeft1=false,posgLeft2=false,posgLeft3=false;
    public static int nbr,selected=0,selectedy=0,selectedg=0;
    public static bool access1, access2,finishone=false,finishoney=false,finishoneg=false;
    public static bool accessred,accessyellow,accessgreen;
    public static bool freered,freeyellow,freegreen,red3=false;
    public static int l;
    public void startd()
    {
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();
        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
    }
    public void Start()
    {
        startd();
    }

    void Update()
    {
        if(enterr==4)
        {
            if(entery==4 || enterg==4)
            {
                p2nd=1;
                SceneManager.LoadScene("MENU 2");
            }
            else 
            {
                p1st=1;
            }
        }
        else if(entery==4)
        {
            if(enterr==4 || enterg==4)
            {
                p2nd=2;
                SceneManager.LoadScene("MENU 2");
            }
            else 
            {
                p1st=2;
            }
        }
        else if(enterg==4)
        {
            if(entery==4 || enterr==4)
            {
                p2nd=3;
                SceneManager.LoadScene("MENU 2");
            }
            else 
            {
                p1st=3;
            }
        }
        if(tour==1)
        {
            bool cant=false;
            if((pos==0 && pos1==0)||(pos==0 && pos2==0)||(pos==0 && pos3==0)||(pos1==0 && pos2==0)||(pos1==0 && pos3==0)||(pos2==0 && pos3==0))
            {
                cant=true;
            }
            if(cant==false)
            {
                if(((finalSide1==5 && access1 && !access2)||(finalSide2==5 && access2 && !access1))&&(pos==-1 || pos1==-1 || pos2==-1 || pos3==-1))
                {
                    freered=true;
                    if (folow_the_path.firstmove == false && pos==-1)
                    {
                        folow_the_path.firstmove = true;pos=0;
                    }
                    else if (folow_the_path1.firstmove1 == false && pos1==-1)
                    {
                        folow_the_path1.firstmove1 = true;pos1=0;
                    }
                    else if (folow_the_path2.firstmove2 == false && pos2==-1)
                    {
                        folow_the_path2.firstmove2 = true;pos2=0;
                    }
                    else if (folow_the_path3.firstmove3 == false && pos3==-1)
                    {
                        folow_the_path3.firstmove3 = true;pos3=0;
                    }
                    access1 = false;
                    access2 = false;
                }
            }
        }
        else if(tour==2)
        {
            bool cant=false;
            if((posy==0 && posy1==0)||(posy==0 && posy2==0)||(posy==0 && posy3==0)||(posy1==0 && posy2==0)||(posy1==0 && posy3==0)||(posy2==0 && posy3==0))
            {
                cant=true;
            }
            if(cant==false)
            {
                if(((finalSide1==5 && access1 && !access2)||(finalSide2==5 && access2 && !access1))&&(posy==-1 || posy1==-1 || posy2==-1 || posy3==-1))
                {
                    freeyellow=true;
                    if (follow_the_path_y1.firstmove == false && posy==-1)
                    {
                         follow_the_path_y1.firstmove = true;posy=0;follow_the_path_y1.x=0;
                    }
                    else if (follow_the_path_y_2.firstmove1 == false && posy1==-1)
                    {
                         follow_the_path_y_2.firstmove1 = true;posy1=0;follow_the_path_y_2.x=0;
                    }
                    else if (follow_the_path_y_3.firstmove2 == false && posy2==-1)
                    {
                         follow_the_path_y_3.firstmove2 = true;posy2=0;follow_the_path_y_3.x=0;
                    }
                    else if (follow_the_path_y_4.firstmove3 == false && posy3==-1)
                    {
                         follow_the_path_y_4.firstmove3 = true;posy3=0;follow_the_path_y_4.x=0;
                    }
                    access1 = false;
                    access2 = false; 
                }
            }
        }
        else
        {
            bool cant=false;
            if((posg==0 && posg1==0)||(posg==0 && posg2==0)||(posg==0 && posg3==0)||(posg1==0 && posg2==0)||(posg1==0 && posg3==0)||(posg2==0 && posg3==0))
            {
                cant=true;
            }
            if(cant==false)
            {
                if(((finalSide1==5 && access1 && !access2)||(finalSide2==5 && access2 && !access1))&&(posg==-1 || posg1==-1 || posg2==-1 || posg3==-1))
                {
                    freegreen=true;
                    if (follow_the_path_g1.firstmove == false && posg==-1)
                    {
                         follow_the_path_g1.firstmove = true;posg=0;follow_the_path_g1.x=0;
                    }
                    else if (follow_the_path_g2.firstmove1 == false && posg1==-1)
                    {
                         follow_the_path_g2.firstmove1 = true;posg1=0;follow_the_path_g2.x=0;
                    }
                    else if (follow_the_path_g3.firstmove2 == false && posg2==-1)
                    {
                         follow_the_path_g3.firstmove2 = true;posg2=0;follow_the_path_g3.x=0;
                    }
                    else if (follow_the_path_g4.firstmove3 == false && posg3==-1)
                    {
                         follow_the_path_g4.firstmove3 = true;posg3=0;follow_the_path_g4.x=0;
                    }
                    access1 = false;
                    access2 = false; 
                }
            }
        }
        
    }

    // If you left click over the dice then RollTheDice coroutine is started
    public void OnMouseDown()
    { 
        StartCoroutine("RollTheDice");  
    }
    public static bool canaccess(int nb,int player)
    {
        bool cant1=false,cant2=false,cant3=false,cant4=false;
        if(player==1)
        {
            if(pos>=0)
            {
                for(int i=Dice.pos + 1;i<=Dice.pos+Dice.nbr;i++)
                {
                    if((Dice.pos1==i && Dice.pos2==i)||(Dice.pos1==i && Dice.pos3==i)||(Dice.pos2==i && Dice.pos3==i))
                    {
                        cant1=true;
                    }
                    if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                    {
                        cant1=true;
                    }
                    if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                    {
                        cant1=true;
                    }
                }
                if((folow_the_path.x+Dice.nbr==51 || folow_the_path.x+Dice.nbr==17 || folow_the_path.x+Dice.nbr==34 || folow_the_path.x+Dice.nbr==7 || folow_the_path.x+Dice.nbr==12 || folow_the_path.x+Dice.nbr==24 || folow_the_path.x+Dice.nbr==29 || folow_the_path.x+Dice.nbr==41 || folow_the_path.x+Dice.nbr==46 || folow_the_path.x+Dice.nbr==58 || folow_the_path.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path.x+Dice.nbr || follow_the_path_g1.x==folow_the_path.x+Dice.nbr || follow_the_path_g2.x==folow_the_path.x+Dice.nbr || follow_the_path_g3.x==folow_the_path.x+Dice.nbr || follow_the_path_g4.x==folow_the_path.x+Dice.nbr))
                {
                    cant1=true;
                }
                if(pos+nb>l) cant1=true;
            }
            else cant1=true;
            if(pos1>=0)
            {
                for(int i=Dice.pos1 + 1;i<=Dice.pos1+Dice.nbr;i++)
                {
                    if((Dice.pos==i && Dice.pos2==i)||(Dice.pos==i && Dice.pos3==i)||(Dice.pos2==i && Dice.pos3==i))
                    {
                        cant2=true;
                    }
                    if((follow_the_path_y1.x+Dice2.nbr==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                    {
                        cant2=true;
                    }
                    if((follow_the_path_g1.x+Dice2.nbr==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                    {
                        cant2=true;
                    }
                }
                    if(((folow_the_path1.x+Dice.nbr==51 || folow_the_path1.x+Dice.nbr==17 || folow_the_path1.x+Dice.nbr==34 || folow_the_path1.x+Dice.nbr==7 || folow_the_path1.x+Dice.nbr==12 || folow_the_path1.x+Dice.nbr==24 || folow_the_path1.x+Dice.nbr==29 || folow_the_path1.x+Dice.nbr==41 || folow_the_path1.x+Dice.nbr==46 || folow_the_path1.x+Dice.nbr==58 || folow_the_path1.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path1.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path1.x+Dice.nbr || follow_the_path_g1.x==folow_the_path1.x+Dice.nbr || follow_the_path_g2.x==folow_the_path1.x+Dice.nbr || follow_the_path_g3.x==folow_the_path1.x+Dice.nbr || follow_the_path_g4.x==folow_the_path1.x+Dice.nbr)))
                    {
                        cant2=true;
                    }
                if(pos1+nb>l) cant2=true;
            }
            else cant2=true;
            if(pos2>=0)
            {
                for(int i=Dice.pos2 + 1;i<=Dice.pos2+Dice.nbr;i++)
                    {
                        if((Dice.pos==i && Dice.pos1==i)||(Dice.pos==i && Dice.pos3==i)||(Dice.pos1==i && Dice.pos3==i))
                        {
                            cant3=true;
                        }
                        if((follow_the_path_y1.x+Dice2.nbr==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant3=true;
                        }
                        if((follow_the_path_g1.x+Dice2.nbr==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant3=true;
                        }
                    }
                    
                    if(((folow_the_path2.x+Dice.nbr==51 || folow_the_path2.x+Dice.nbr==17 || folow_the_path2.x+Dice.nbr==34 || folow_the_path2.x+Dice.nbr==7 || folow_the_path2.x+Dice.nbr==12 || folow_the_path2.x+Dice.nbr==24 || folow_the_path2.x+Dice.nbr==29 || folow_the_path2.x+Dice.nbr==41 || folow_the_path2.x+Dice.nbr==46 || folow_the_path2.x+Dice.nbr==58 || folow_the_path2.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path2.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path2.x+Dice.nbr || follow_the_path_g1.x==folow_the_path2.x+Dice.nbr || follow_the_path_g2.x==folow_the_path2.x+Dice.nbr || follow_the_path_g3.x==folow_the_path2.x+Dice.nbr || follow_the_path_g4.x==folow_the_path2.x+Dice.nbr)))
                    {
                        cant3=true;
                    }
                if(pos2+nb>l) cant3=true;
            }
            else cant3=true;
            if(pos3>=0)
            {
                    for(int i=Dice.pos3 + 1;i<=Dice.pos3+Dice.nbr;i++)
                    {
                        if((Dice.pos==i && Dice.pos1==i)||(Dice.pos==i && Dice.pos2==i)||(Dice.pos1==i && Dice.pos2==i))
                        {
                            cant4=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant4=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant4=true;
                        }
                    }
                    if(((folow_the_path3.x+Dice.nbr==51 || folow_the_path3.x+Dice.nbr==17 || folow_the_path3.x+Dice.nbr==34 || folow_the_path3.x+Dice.nbr==7 || folow_the_path3.x+Dice.nbr==12 || folow_the_path3.x+Dice.nbr==24 || folow_the_path3.x+Dice.nbr==29 || folow_the_path3.x+Dice.nbr==41 || folow_the_path3.x+Dice.nbr==46 || folow_the_path3.x+Dice.nbr==58 || folow_the_path3.x+Dice.nbr==63)&&(follow_the_path_y1.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_2.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_3.x==folow_the_path3.x+Dice.nbr || follow_the_path_y_4.x==folow_the_path3.x+Dice.nbr || follow_the_path_g1.x==folow_the_path3.x+Dice.nbr || follow_the_path_g2.x==folow_the_path3.x+Dice.nbr || follow_the_path_g3.x==folow_the_path3.x+Dice.nbr || follow_the_path_g4.x==folow_the_path3.x+Dice.nbr)))
                    {
                        cant4=true;
                    }
                if(pos3+nb>l) cant4=true;
            }
            else cant4=true;
            if(cant1==true && cant2==true && cant3==true && cant4==true)
            {    //Debug.Log("entre false");
                return false;
            }
            else
            {//Debug.Log("entre true");
                return true;
            } 
        }
        else if(player ==2)
        {
            if(posy>=0)
            {
                if(posy+nb>l)
                {
                     cant1=true;////Debug.Log("entre more max");
                }
                else
                {
                    
                    for(int i=follow_the_path_y1.x + 1;i<=follow_the_path_y1.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant1=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant1=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant1=true;
                        }
                    }
                    if((follow_the_path_y1.x+Dice.nbr==51 || follow_the_path_y1.x+Dice.nbr==17 || follow_the_path_y1.x+Dice.nbr==34 || follow_the_path_y1.x+Dice.nbr==7 || follow_the_path_y1.x+Dice.nbr==12 || follow_the_path_y1.x+Dice.nbr==24 || follow_the_path_y1.x+Dice.nbr==29 || follow_the_path_y1.x+Dice.nbr==41 || follow_the_path_y1.x+Dice.nbr==46 || follow_the_path_y1.x+Dice.nbr==58 || follow_the_path_y1.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y1.x+Dice.nbr || folow_the_path1.x==follow_the_path_y1.x+Dice.nbr || folow_the_path.x==follow_the_path_y1.x+Dice.nbr || folow_the_path3.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y1.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y1.x+Dice.nbr))
                    {
                        cant1=true;
                    }
                }
                
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy);
            } 
            if(posy1>=0)
            {
                if(posy1+nb>l)
                {
                    cant2=true;////Debug.Log("entre more max");
                } 
                else
                {
                    
                    for(int i=follow_the_path_y_2.x + 1;i<=follow_the_path_y_2.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant2=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant2=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant2=true;
                        }
                    }
                    if((follow_the_path_y_2.x+Dice.nbr==51 || follow_the_path_y_2.x+Dice.nbr==17 || follow_the_path_y_2.x+Dice.nbr==34 || follow_the_path_y_2.x+Dice.nbr==7 || follow_the_path_y_2.x+Dice.nbr==12 || follow_the_path_y_2.x+Dice.nbr==24 || follow_the_path_y_2.x+Dice.nbr==29 || follow_the_path_y_2.x+Dice.nbr==41 || follow_the_path_y_2.x+Dice.nbr==46 || follow_the_path_y_2.x+Dice.nbr==58 || follow_the_path_y_2.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_2.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_2.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_2.x+Dice.nbr))
                    {
                        cant2=true;
                    }
                }
                
            }
            else
            {
                cant2=true;////Debug.Log("entre not free"+posy1);
            } 
            if(posy2>=0)
            {
                if(posy2+nb>l)
                {
                    cant3=true;////Debug.Log("entre more max");
                } 
                else{
                    for(int i=follow_the_path_y_3.x + 1;i<=follow_the_path_y_3.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i))
                        {
                            cant3=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant3=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant3=true;
                        }
                    }
                    if((follow_the_path_y_3.x+Dice.nbr==51 || follow_the_path_y_3.x+Dice.nbr==17 || follow_the_path_y_3.x+Dice.nbr==34 || follow_the_path_y_3.x+Dice.nbr==7 || follow_the_path_y_3.x+Dice.nbr==12 || follow_the_path_y_3.x+Dice.nbr==24 || follow_the_path_y_3.x+Dice.nbr==29 || follow_the_path_y_3.x+Dice.nbr==41 || follow_the_path_y_3.x+Dice.nbr==46 || follow_the_path_y_3.x+Dice.nbr==58 || follow_the_path_y_3.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_3.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_3.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_3.x+Dice.nbr))
                    {
                        cant3=true;
                    }
                }
                
            }
            else
            {
                cant3=true;////Debug.Log("entre not free"+posy2);
            } 
            if(posy3>=0)
            {
                if(posy3+nb>l) 
                {
                    cant4=true;////Debug.Log("entre more max");
                }
                else{
                    
                    for(int i=follow_the_path_y_4.x + 1;i<=follow_the_path_y_4.x+Dice.nbr;i++)
                    {
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i))
                        {
                            cant4=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant4=true;
                        }
                        if((follow_the_path_g1.x==i && follow_the_path_g2.x==i)||(follow_the_path_g1.x==i && follow_the_path_g3.x==i)||(follow_the_path_g1.x==i && follow_the_path_g4.x==i)||(follow_the_path_g2.x==i && follow_the_path_g3.x==i)||(follow_the_path_g2.x==i && follow_the_path_g4.x==i)||(follow_the_path_g3.x==i && follow_the_path_g4.x==i))
                        {
                            cant4=true;
                        }
                    }
                    if((follow_the_path_y_4.x+Dice.nbr==51 || follow_the_path_y_4.x+Dice.nbr==17 || follow_the_path_y_4.x+Dice.nbr==34 || follow_the_path_y_4.x+Dice.nbr==7 || follow_the_path_y_4.x+Dice.nbr==12 || follow_the_path_y_4.x+Dice.nbr==24 || follow_the_path_y_4.x+Dice.nbr==29 || follow_the_path_y_4.x+Dice.nbr==41 || follow_the_path_y_4.x+Dice.nbr==46 || follow_the_path_y_4.x+Dice.nbr==58 || follow_the_path_y_4.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path1.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path2.x==follow_the_path_y_4.x+Dice.nbr || folow_the_path3.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g1.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g2.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g3.x==follow_the_path_y_4.x+Dice.nbr || follow_the_path_g4.x==follow_the_path_y_4.x+Dice.nbr))
                    {
                        cant4=true;
                    }
                }
            }
            else
            {
                cant4=true;////Debug.Log("entre not free"+posy3);
            } 
            if(cant1==true && cant2==true && cant3==true && cant4==true)
            {    //Debug.Log("entre false");
                return false;
            }
            else
            {//Debug.Log("entre true");
                return true;
            } 
        }
        else
        {
            if(posg>=0)
            {
                if(posg+nb>l)
                {
                     cant1=true;////Debug.Log("entre more max");
                }
                else
                {
                    for(int i=Dice.posg + 1;i<=Dice.posg+Dice.nbr;i++)
                    {
                        if((Dice.posg1==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg3==i)||(Dice.posg2==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cant1=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant1=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant1=true;
                        }
                    } 
                    if((follow_the_path_g1.x+Dice.nbr==51 || follow_the_path_g1.x+Dice.nbr==17 || follow_the_path_g1.x+Dice.nbr==34 || follow_the_path_g1.x+Dice.nbr==7 || follow_the_path_g1.x+Dice.nbr==12 || follow_the_path_g1.x+Dice.nbr==24 || follow_the_path_g1.x+Dice.nbr==29 || follow_the_path_g1.x+Dice.nbr==41 || follow_the_path_g1.x+Dice.nbr==46 || follow_the_path_g1.x+Dice.nbr==58 || follow_the_path_g1.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g1.x+Dice.nbr || folow_the_path1.x==follow_the_path_g1.x+Dice.nbr || folow_the_path2.x==follow_the_path_g1.x+Dice.nbr || folow_the_path3.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g1.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g1.x+Dice.nbr ))
                    {
                        cant1=true;
                    }
                }
                
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy);
            } 
            if(posg1>=0)
            {
                if(posg1+nb>l)
                {
                    cant2=true;////Debug.Log("entre more max");
                } 
                else
                {
                    for(int i=Dice.posg1 + 1;i<=Dice.posg1+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg3==i)||(Dice.posg2==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cant2=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant2=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant2=true;
                        }
                    }
                    if((follow_the_path_g2.x+Dice.nbr==51 || follow_the_path_g2.x+Dice.nbr==17 || follow_the_path_g2.x+Dice.nbr==34 || follow_the_path_g2.x+Dice.nbr==7 || follow_the_path_g2.x+Dice.nbr==12 || follow_the_path_g2.x+Dice.nbr==24 || follow_the_path_g2.x+Dice.nbr==29 || follow_the_path_g2.x+Dice.nbr==41 || follow_the_path_g2.x+Dice.nbr==46 || follow_the_path_g2.x+Dice.nbr==58 || follow_the_path_g2.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g2.x+Dice.nbr || folow_the_path1.x==follow_the_path_g2.x+Dice.nbr || folow_the_path2.x==follow_the_path_g2.x+Dice.nbr || folow_the_path3.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g2.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g2.x+Dice.nbr))
                    {
                        cant2=true;
                    }   
                }
                
            }
            else
            {
                cant2=true;////Debug.Log("entre not free"+posy1);
            } 
            if(posg2>=0)
            {
                if(posg2+nb>l)
                {
                    cant3=true;////Debug.Log("entre more max");
                } 
                else{
                    for(int i=Dice.posg2 + 1;i<=Dice.posg2+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg1==i)||(Dice.posg==i && Dice.posg3==i)||(Dice.posg1==i && Dice.posg3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cant3=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant3=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant3=true;
                        }
                    }
                    if((follow_the_path_g3.x+Dice.nbr==51 || follow_the_path_g3.x+Dice.nbr==17 || follow_the_path_g3.x+Dice.nbr==34 || follow_the_path_g3.x+Dice.nbr==7 || follow_the_path_g3.x+Dice.nbr==12 || follow_the_path_g3.x+Dice.nbr==24 || follow_the_path_g3.x+Dice.nbr==29 || follow_the_path_g3.x+Dice.nbr==41 || follow_the_path_g3.x+Dice.nbr==46 || follow_the_path_g3.x+Dice.nbr==58 || follow_the_path_g3.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g3.x+Dice.nbr || folow_the_path1.x==follow_the_path_g3.x+Dice.nbr || folow_the_path2.x==follow_the_path_g3.x+Dice.nbr || folow_the_path3.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g3.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g3.x+Dice.nbr))
                    {
                        cant3=true;
                    }
                }
                
            }
            else
            {
                cant3=true;////Debug.Log("entre not free"+posy2);
            } 
            if(posg3>=0)
            {
                if(posg3+nb>l) 
                {
                    cant4=true;////Debug.Log("entre more max");
                }
                else{
                    for(int i=Dice.posg3 + 1;i<=Dice.posg3+Dice.nbr;i++)
                    {
                        if((Dice.posg==i && Dice.posg1==i)||(Dice.posg==i && Dice.posg2==i)||(Dice.posg1==i && Dice.posg2==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+Dice.posy);
                            cant4=true;
                        }
                        if((folow_the_path.x==i && folow_the_path1.x==i)||(folow_the_path.x==i && folow_the_path2.x==i)||(folow_the_path.x==i && folow_the_path3.x==i)||(folow_the_path1.x==i && folow_the_path2.x==i)||(folow_the_path1.x==i && folow_the_path3.x==i)||(folow_the_path2.x==i && folow_the_path3.x==i))
                        {
                            cant4=true;
                        }
                        if((follow_the_path_y1.x==i && follow_the_path_y_2.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y1.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_3.x==i)||(follow_the_path_y_2.x==i && follow_the_path_y_4.x==i)||(follow_the_path_y_3.x==i && follow_the_path_y_4.x==i))
                        {
                            cant4=true;
                        }
                    }
                    if((follow_the_path_g4.x+Dice.nbr==51 || follow_the_path_g4.x+Dice.nbr==17 || follow_the_path_g4.x+Dice.nbr==34 || follow_the_path_g4.x+Dice.nbr==7 || follow_the_path_g4.x+Dice.nbr==12 || follow_the_path_g4.x+Dice.nbr==24 || follow_the_path_g4.x+Dice.nbr==29 || follow_the_path_g4.x+Dice.nbr==41 || follow_the_path_g4.x+Dice.nbr==46 || follow_the_path_g4.x+Dice.nbr==58 || follow_the_path_g4.x+Dice.nbr==63)&&(folow_the_path.x==follow_the_path_g4.x+Dice.nbr || folow_the_path1.x==follow_the_path_g4.x+Dice.nbr || folow_the_path2.x==follow_the_path_g4.x+Dice.nbr || folow_the_path3.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y1.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_2.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_3.x==follow_the_path_g4.x+Dice.nbr || follow_the_path_y_4.x==follow_the_path_g4.x+Dice.nbr))
                    {
                        cant4=true;
                    }
                }
            }
            else
            {
                cant4=true;////Debug.Log("entre not free"+posy3);
            } 
            if(cant1==true && cant2==true && cant3==true && cant4==true)
            {    //Debug.Log("entre false");
                return false;
            }
            else
            {//Debug.Log("entre true");
                return true;
            } 
        }
    }
    // Coroutine that rolls the dice
    public IEnumerator RollTheDice()
    {
       // Debug.Log(pos+" "+pos1+" "+pos2+" "+pos3);
        if (access1 == false && access2 == false)//////////////////////////////////////////////////////////////////////////////////////////////////
        {
            if(finalSide1!=finalSide2)
            {
                if(tour==1) tour++;
                else if(tour==2) tour++;
                else tour=1;
            }
            if(tour==1)
            {
                accessred=true; 
                accessyellow=false;
                accessgreen=false;
                rend.GetComponent<SpriteRenderer>().material.color = Color.red;
            }
            else if(tour==2)
            {
                accessred=false;
                accessgreen=false;
                accessyellow=true;
                rend.GetComponent<SpriteRenderer>().material.color = Color.yellow;
            }
            else
            {
                accessred=false;
                accessgreen=true;
                accessyellow=false;
                rend.GetComponent<SpriteRenderer>().material.color = Color.green;
            }
            numberImg.hideimg(); numberImg.show = false;////////////////
            numberImg1.hideimg(); numberImg1.show = false;///////////////////
            // corountineAllowed = false;
            int randomDiceSide = 0;
            for (int i = 0; i <= 20; i++)
            {
                randomDiceSide = Random.Range(0, 36);
                rend.sprite = diceSides[randomDiceSide];
                yield return new WaitForSeconds(0.05f);
            }
            //////Debug.Log(randomDiceSide+1);
            switch (randomDiceSide + 1)
            {
                case 1:
                    finalSide1 = 1;
                    finalSide2 = 1;
                    break;
                case 2:
                    finalSide1 = 1;
                    finalSide2 = 2;
                    break;
                case 3:
                    finalSide1 = 1;
                    finalSide2 = 3;
                    break;
                case 4:
                    finalSide1 = 1;
                    finalSide2 = 4;
                    break;
                case 5:
                    finalSide1 = 1;
                    finalSide2 = 5;
                    break;
                case 6:
                    finalSide1 = 1;
                    finalSide2 = 6;
                    break;
                case 7:
                    finalSide1 = 2;
                    finalSide2 = 1;
                    break;
                case 8:
                    finalSide1 = 2;
                    finalSide2 = 2;
                    break;
                case 9:
                    finalSide1 = 2;
                    finalSide2 = 3;
                    break;
                case 10:
                    finalSide1 = 2;
                    finalSide2 = 4;
                    break;
                case 11:
                    finalSide1 = 2;
                    finalSide2 = 5;
                    break;
                case 12:
                    finalSide1 = 2;
                    finalSide2 = 6;
                    break;
                case 13:
                    finalSide1 = 3;
                    finalSide2 = 1;
                    break;
                case 14:
                    finalSide1 = 3;
                    finalSide2 = 2;
                    break;
                case 15:
                    finalSide1 = 3;
                    finalSide2 = 3;
                    break;
                case 16:
                    finalSide1 = 3;
                    finalSide2 = 4;
                    break;
                case 17:
                    finalSide1 = 3;
                    finalSide2 = 5;
                    break;
                case 18:
                    finalSide1 = 3;
                    finalSide2 = 6;
                    break;
                case 19:
                    finalSide1 = 4;
                    finalSide2 = 1;
                    break;
                case 20:
                    finalSide1 = 4;
                    finalSide2 = 2;
                    break;
                case 21:
                    finalSide1 = 4;
                    finalSide2 = 3;
                    break;
                case 22:
                    finalSide1 = 4;
                    finalSide2 = 4;
                    break;
                case 23:
                    finalSide1 = 4;
                    finalSide2 = 5;
                    break;
                case 24:
                    finalSide1 = 4;
                    finalSide2 = 6;
                    break;
                case 25:
                    finalSide1 = 5;
                    finalSide2 = 1;
                    break;
                case 26:
                    finalSide1 = 5;
                    finalSide2 = 2;
                    break;
                case 27:
                    finalSide1 = 5;
                    finalSide2 = 3;
                    break;
                case 28:
                    finalSide1 = 5;
                    finalSide2 = 4;
                    break;
                case 29:
                    finalSide1 = 5;
                    finalSide2 = 5;
                    break;
                case 30:
                    finalSide1 = 5;
                    finalSide2 = 6;
                    break;
                case 31:
                    finalSide1 = 6;
                    finalSide2 = 1;
                    break;
                case 32:
                    finalSide1 = 6;
                    finalSide2 = 2;
                    break;
                case 33:
                    finalSide1 = 6;
                    finalSide2 = 3;
                    break;
                case 34:
                    finalSide1 = 6;
                    finalSide2 = 4;
                    break;
                case 35:
                    finalSide1 = 6;
                    finalSide2 = 5;
                    break;
                case 36:
                    finalSide1 = 6;
                    finalSide2 = 6;
                    break;
            }
            if(tour==1)
            {
                numberImg.setimg(finalSide1);
                numberImg1.setimg(finalSide2);
                folow_the_path.click = false;
                folow_the_path1.click = false;
                folow_the_path2.click = false;
                folow_the_path3.click = false;
                bool cant=false,cant2=true;
                if((pos==0 && pos1==0)||(pos==0 && pos2==0)||(pos==0 && pos3==0)||(pos1==0 && pos2==0)||(pos1==0 && pos3==0)||(pos2==0 && pos3==0))
                {
                    cant=true;
                }
                if((posy==34 && posy1==34)||(posy==34 && posy2==34)||(posy==34 && posy3==34)||(posy1==34 && posy2==34)||(posy1==34 && posy3==34)||(posy2==34 && posy3==34))
                {
                    cant=true;
                }
                if((posg==51 && posg1==51)||(posg==51 && posg2==51)||(posg==51 && posg3==51)||(posg1==51 && posg2==51)||(posg1==51 && posg3==51)||(posg2==51 && posg3==51))
                {
                    cant=true; 
                }
                if(pos!=0 && pos1!=0 && pos2!=0 && pos3!=0 && posy!=34 && posy1!=34 && posy2!=34 && posy3!=34 && posg!=51 && posg1!=51 && posg2!=51 && posg3!=51)
                {
                    cant2=false;
                }
                int cp=0;
                if(pos==-1) cp++;
                if(pos1==-1) cp++;
                if(pos2==-1) cp++;
                if(pos3==-1) cp++;
                if ((cant2==false)&&(finalSide1 == 5 && finalSide2 == 5)&&(cp>=2))
                {
                    access1 = false;
                    access2 = false;
                    freered=true;
                    cp=0;
                    if (folow_the_path.firstmove == false && pos==-1 && cp<2) 
                    {
                        folow_the_path.firstmove = true;pos=0;cp++;
                    }
                    if (folow_the_path1.firstmove1 == false && pos1==-1 && cp<2) 
                    {
                        folow_the_path1.firstmove1 = true;pos1=0;cp++;
                    }
                    if (folow_the_path2.firstmove2 == false && pos2==-1 && cp<2)
                    {
                        folow_the_path2.firstmove2 = true;pos2=0;cp++;
                    }
                    if (folow_the_path3.firstmove3 == false && pos3==-1 && cp<2)
                    {
                        folow_the_path3.firstmove3 = true;pos3=0;cp++;
                    } 
                }
                else if ((pos==-1 || pos1==-1 || pos2==-1 || pos3==-1)&&(cant==false)&&(finalSide1 == 5 || finalSide2 == 5 || finalSide1 + finalSide2 == 5))
                {
                    freered=true;
                    if (folow_the_path.firstmove == false && pos==-1)
                    {
                        folow_the_path.firstmove = true;pos=0;
                    }
                    else if (folow_the_path1.firstmove1 == false && pos1==-1)
                    {
                        folow_the_path1.firstmove1 = true;pos1=0;
                    }
                    else if (folow_the_path2.firstmove2 == false && pos2==-1)
                    {
                        folow_the_path2.firstmove2 = true;pos2=0;
                    }
                    else if (folow_the_path3.firstmove3 == false && pos3==-1)
                    {
                        folow_the_path3.firstmove3 = true;pos3=0;
                    }
                    if (finalSide1 == 5)
                    {
                        access2=canaccess(finalSide2,1);
                        access1 = false;
                    }
                    else if (finalSide2 == 5)
                    {
                        access1=canaccess(finalSide1,1);
                        access2 = false;
                    }
                    else if (finalSide2 + finalSide1 == 5)
                    {
                        access1 = false;
                        access2 = false;
                    }
                }
                else if (pos == -1 && pos1 == -1 && pos2 == -1 && pos3 == -1)
                {
                    access1 = false;
                    access2 = false;
                }
                else
                {
                    access1=canaccess(finalSide1,1);
                    access2=canaccess(finalSide2,1);
                }
            }
            else if(tour==2)
            {
                numberImg.setimg(finalSide1);
                numberImg1.setimg(finalSide2);
                follow_the_path_y1.click = false;
                follow_the_path_y_2.click = false;
                follow_the_path_y_3.click = false;
                follow_the_path_y_4.click = false;
                bool cant=false,cant2=true;
                if((posy==0 && posy1==0)||(posy==0 && posy2==0)||(posy==0 && posy3==0)||(posy1==0 && posy2==0)||(posy1==0 && posy3==0)||(posy2==0 && posy3==0))
                {
                    cant=true;
                }
                if((pos==34 && pos1==34)||(pos==34 && pos2==34)||(pos==34 && pos3==34)||(pos1==34 && pos2==34)||(pos1==34 && pos3==34)||(pos2==34 && pos3==34))
                {
                    cant=true;
                }
                if((posg==17 && posg1==17)||(posg==17 && posg2==17)||(posg==17 && posg3==17)||(posg1==17 && posg2==17)||(posg1==17 && posg3==17)||(posg2==17 && posg3==17))
                {
                    cant=true;
                }
                if(pos!=34 && pos1!=34 && pos2!=34 && pos3!=34 && posy!=0 && posy1!=0 && posy2!=0 && posy3!=0 && posg!=17 && posg1!=17 && posg2!=17 && posg3!=17)
                {
                    cant2=false;
                }
                int cp=0;
                if(posy==-1) cp++;
                if(posy1==-1) cp++;
                if(posy2==-1) cp++;
                if(posy3==-1) cp++;
                if ((cant2==false)&&(finalSide1 == 5 && finalSide2 == 5)&&(cp>=2))
                {
                    access1 = false;
                    access2 = false;
                    freeyellow=true;
                    cp=0;
                    if (follow_the_path_y1.firstmove == false && posy==-1 && cp<2) 
                    {
                        follow_the_path_y1.firstmove = true;posy=0;follow_the_path_y1.x=0;cp++;
                    }
                    if (follow_the_path_y_2.firstmove1 == false && posy1==-1 && cp<2) 
                    {
                        follow_the_path_y_2.firstmove1 = true;posy1=0;follow_the_path_y_2.x=0;cp++;
                    }
                    if (follow_the_path_y_3.firstmove2 == false && posy2==-1 && cp<2)
                    {
                        follow_the_path_y_3.firstmove2 = true;posy2=0;follow_the_path_y_3.x=0;cp++;
                    }
                    if (follow_the_path_y_4.firstmove3 == false && posy3==-1 && cp<2)
                    {
                        follow_the_path_y_4.firstmove3 = true;posy3=0;follow_the_path_y_4.x=0;cp++;
                    } 
                }
                else if((posy==-1 || posy1==-1 || posy2==-1 || posy3==-1)&&(cant==false)&&(finalSide1 == 5 || finalSide2 == 5 || finalSide1 + finalSide2 == 5))
                {
                    freeyellow=true;
                    if (follow_the_path_y1.firstmove == false && posy==-1)
                    {
                         follow_the_path_y1.firstmove = true;posy=0;follow_the_path_y1.x=0;
                    }
                    else if (follow_the_path_y_2.firstmove1 == false && posy1==-1)
                    {
                         follow_the_path_y_2.firstmove1 = true;posy1=0;follow_the_path_y_2.x=0;
                    }
                    else if (follow_the_path_y_3.firstmove2 == false && posy2==-1)
                    {
                         follow_the_path_y_3.firstmove2 = true;posy2=0;follow_the_path_y_3.x=0;
                    }
                    else if (follow_the_path_y_4.firstmove3 == false && posy3==-1)
                    {
                         follow_the_path_y_4.firstmove3 = true;posy3=0;follow_the_path_y_4.x=0;
                    }
                    if (finalSide1 == 5)
                    {
                        access2=canaccess(finalSide2,2);
                        access1 = false;
                    }
                    else if (finalSide2 == 5)
                    {
                        access1=canaccess(finalSide1,2);
                        access2 = false;
                    }
                    else if (finalSide2 + finalSide1 == 5)
                    {
                        access1 = false;
                        access2 = false; 
                    }
                }
                else if (posy == -1 && posy1 == -1 && posy2 == -1 && posy3 == -1)
                {
                    access1 = false;
                    access2 = false;
                }
                else
                {
                    access1=canaccess(finalSide1,2);
                    access2=canaccess(finalSide2,2);
                }
            }
            else
            {
                numberImg.setimg(finalSide1);
                numberImg1.setimg(finalSide2);
                follow_the_path_g1.click = false;
                follow_the_path_g2.click = false;
                follow_the_path_g3.click = false;
                follow_the_path_g4.click = false;
                bool cant=false,cant2=true;
                if((posg==0 && posg1==0)||(posg==0 && posg2==0)||(posg==0 && posg3==0)||(posg1==0 && posg2==0)||(posg1==0 && posg3==0)||(posg2==0 && posg3==0))
                {
                    cant=true;
                }
                if((pos==17 && pos1==17)||(pos==17 && pos2==17)||(pos==17 && pos3==17)||(pos1==17 && pos2==17)||(pos1==17 && pos3==17)||(pos2==17 && pos3==17))
                {
                    cant=true;
                }
                if((posy==51 && posy1==51)||(posy==51 && posy2==51)||(posy==51 && posy3==51)||(posy1==51 && posy2==51)||(posy1==51 && posy3==51)||(posy2==51 && posy3==51))
                {
                    cant=true;
                }
                if(pos!=17 && pos1!=17 && pos2!=17 && pos3!=17 && posy!=51 && posy1!=51 && posy2!=51 && posy3!=51 && posg!=0 && posg1!=0 && posg2!=0 && posg3!=0)////////////////////////////
                {
                    cant2=false;
                }
                int cp=0;
                if(posg==-1) cp++;
                if(posg1==-1) cp++;
                if(posg2==-1) cp++;
                if(posg3==-1) cp++;
                if ((cant2==false)&&(finalSide1 == 5 && finalSide2 == 5)&&(cp>=2))
                {
                    access1 = false;
                    access2 = false;
                    freegreen=true;
                    cp=0;
                    if (follow_the_path_g1.firstmove == false && posg==-1 && cp<2) 
                    {
                        follow_the_path_g1.firstmove = true;posg=0;follow_the_path_g1.x=0;cp++;
                    }
                    if (follow_the_path_g2.firstmove1 == false && posg1==-1 && cp<2) 
                    {
                        follow_the_path_g2.firstmove1 = true;posg1=0;follow_the_path_g2.x=0;cp++;
                    }
                    if (follow_the_path_g3.firstmove2 == false && posg2==-1 && cp<2)
                    {
                        follow_the_path_g3.firstmove2 = true;posg2=0;follow_the_path_g3.x=0;cp++;
                    }
                    if (follow_the_path_g4.firstmove3 == false && posg3==-1 && cp<2)
                    {
                        follow_the_path_g4.firstmove3 = true;posg3=0;follow_the_path_g4.x=0;cp++;
                    } 
                }
                else if((posg==-1 || posg1==-1 || posg2==-1 || posg3==-1)&&(cant==false)&&(finalSide1 == 5 || finalSide2 == 5 || finalSide1 + finalSide2 == 5))
                {
                    freegreen=true;
                    if (follow_the_path_g1.firstmove == false && posg==-1)
                    {
                         follow_the_path_g1.firstmove = true;posg=0;follow_the_path_g1.x=0;
                    }
                    else if (follow_the_path_g2.firstmove1 == false && posg1==-1)
                    {
                         follow_the_path_g2.firstmove1 = true;posg1=0;follow_the_path_g2.x=0;
                    }
                    else if (follow_the_path_g3.firstmove2 == false && posg2==-1)
                    {
                         follow_the_path_g3.firstmove2 = true;posg2=0;follow_the_path_g3.x=0;
                    }
                    else if (follow_the_path_g4.firstmove3 == false && posg3==-1)
                    {
                         follow_the_path_g4.firstmove3 = true;posg3=0;follow_the_path_g4.x=0;
                    }
                    if (finalSide1 == 5)
                    {
                        Debug.Log("entre a green 5");
                        access2=canaccess(finalSide2,3);
                        access1 = false;
                    }
                    else if (finalSide2 == 5)
                    {
                        Debug.Log("entre a green 5");
                        access1=canaccess(finalSide1,3);
                        access2 = false;
                    }
                    else if (finalSide2 + finalSide1 == 5)
                    {
                        access1 = false;
                        access2 = false; 
                    }
                }
                else if (posg == -1 && posg1 == -1 && posg2 == -1 && posg3 == -1)
                {
                    access1 = false;
                    access2 = false;
                }
                else
                {
                    Debug.Log("entre a green");
                    access1=canaccess(finalSide1,3);
                    access2=canaccess(finalSide2,3);
                }
            }
        }
    }
}
